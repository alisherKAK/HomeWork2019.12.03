$("input").on("click", function (e) {
    var id = $(this).data("taskId");
    $.ajax({
        type: "POST",
        url: "Task/ChangeState/" + id,
        success: function (data) {
        }
    });

    return true;
});