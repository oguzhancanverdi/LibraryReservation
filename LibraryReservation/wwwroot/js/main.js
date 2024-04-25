var App = {
    Init: function (e) {
        this.Reservation();
        this.User();
    },
    Reservation: function () {
        $(".boxDiv").click(function (e) {
            var model = {
                seatId: e.target.id
            };

            $.ajax({
                url: "api/Reservations",
                type: "POST",
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (result) {
                    alert("İşlem başarılı");
                },
                error: function (xhr, status, error) {
                    alert(xhr.responseText);
                }
            });
        });
    },
    User: function () {
        UserId = "asdsa";
        UserName = "";
        FirstName = "";
        LastName = "";
    }
}

App.Init();