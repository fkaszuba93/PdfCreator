
$('#downloadButton').click(() => {
    $.ajax({
        type: 'POST',
        url: '/api/Documents/Create',
        data: JSON.stringify($('#documentContainer').html()),
        contentType: 'application/json',
        success: (id) => {
            window.open(`/api/Documents/Download/${id}`);
        }
    });
});

$('#addElementButton').click(() => {
    var text = $('#elementText').val();
    $('#documentContent').append(`<div style="padding-bottom: 0.25rem;">${text}</div>`);
});
