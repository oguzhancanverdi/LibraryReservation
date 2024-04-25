var App = {
    Init: function (e) {
        this.Reservation();
        this.User();
    },
    Reservation: function () {
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

        async function TemporarilyRreserved(e) {

            await wait(10000);

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