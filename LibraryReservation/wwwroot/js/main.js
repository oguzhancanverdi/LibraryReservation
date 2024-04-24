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
                time: '2024-04-25'
            };

            $.ajax({
                url: "api/Reservations",
                type: "POST",
                data: JSON.stringify(model),
                contentType: "application/json",
                success: function (result) {
                    console.log("Ýþlem baþarýlý");
                },
                error: function (xhr, status, error) {
                    console.error("Hata oluþtu: " + error);
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