var App = {
    Init: function (e) {
        this.Reservation();
        this.User();
    },
    Reservation: function () {

        var actions = {
            "Rezervasyon": 1,
            "Iptal": 2
        }

        var boxDiv = $(".boxDiv");
        if (boxDiv) {
            $(".boxDiv").click(function (e) {

                var model = {
                    seatId: e ? e.target.id : ""
                };

                $.ajax({
                    url: "api/Reservations",
                    type: "POST",
                    data: JSON.stringify(model),
                    contentType: "application/json; charset=utf-8",
                    success: function (result) {
                        location.reload();
                        alert("İşlem başarılı");
                    },
                    error: function (xhr, status, error) {
                        alert(xhr.responseText);
                    }
                });
            });
        }

        var boxDivActive = $(".boxDivActive");
        if (boxDivActive) {
            $(".boxDivActive").click(function (e) {

                var model = {
                    Id: e ? e.target.id : "",
                    IsReserved: false,
                    Name: ""
                };

                $.ajax({
                    url: "api/Seats",
                    type: "PUT",
                    data: JSON.stringify(model),
                    contentType: "application/json; charset=utf-8",
                    success: function (result) {
                        location.reload();
                    },
                    error: function (xhr, status, error) {
                        alert(xhr.responseText);
                    }
                });
            });
        }

        /*
            Signal R js kütüphanesi kullanılarak ReservationHub ile bağlantı kuruluyor.
            Butonlara tıklandıktan sonra değerlere göre farklı işlemler yapılıyor.
            Eğer reservasyon yapıldıysa sayfa tüm istemcilerde yenileniyor ve aktif olanlar görülüyor.
            Rezervasyon iptal edildiyse diğer istemcilere mesaj gidiyor ve seçim iptal ediliyor.

            Not: Kodlar yeterince temiz değil. İşlemlerin çalışabilir durumda olması için bu şekilde bırakıldı.
        */
        var connection = new signalR.HubConnectionBuilder().withUrl("https://localhost:7295/ReservationHub").build();
        connection.start().then(() => {
            ShowConnectionState();
        }).catch((err) => {
            ShowConnectionState();
            console.log('Hata : ');
        });

        connection.on("ReceiveName", (name) => {
            if (name === actions.Rezervasyon)
                location.reload();
            else
                $('#listName').append(`<li class="list-group-item"> ${name}</li>`)
        })
        function ShowConnectionState() {
            $('.boxDiv').click(() => {
                connection.invoke("SendName", actions.Rezervasyon);
            });

            $(".boxDivActive").click(function (e) {
                connection.invoke("SendName", e.target.innerText + " numaralı koltuk artık seçilebilir.");
            });
        }

    },
    User: function () {
        UserId = "";
        UserName = "";
        FirstName = "";
        LastName = "";
    }
}

App.Init();