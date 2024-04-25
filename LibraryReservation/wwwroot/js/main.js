var App = {
    Init: function (e) {
        this.Reservation();
        this.User();
    },
    Reservation: function () {
        $(".boxDiv").click(function (e) {
            var model = {
                seatId: e.target.id,
                userId: UserId,
                startTime: '2024-04-25',
                endTime: '2024-04-25'
            };

            $.ajax({
                url: "api/Reservations",
                type: "POST",
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (result) {
                    console.log("İşlem başarılı");
                },
                error: function (xhr, status, error) {
                    console.error("Hata oluştu: " + error);
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