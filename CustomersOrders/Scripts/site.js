$("#Customers").bind("change", function () {
    UpdateOrder();
});

function UpdateOrder() {
    $.ajax({
        type: "GET",
        url: webroot+"/"+ Customers.value,
    }).done(function (result) {
        $("#Orders").html(result);
    }).fail(function (err) {
        alert(err.responseText);
    });
}