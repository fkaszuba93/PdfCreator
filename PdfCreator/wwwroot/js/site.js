
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
    var selectedType = $('#elementType').val();
    var text = $('#elementText').val();
    var id = $('#elementId').val();
    var element;
    if (selectedType === 'text') {
        element = text;
    } else {
        element = `<input type="${selectedType}" id="${id}" name="${id}" />
                    <label for="${id}">${text}</label>`;
    }
    $('#documentContent').append(`<div style="padding-bottom: 0.25rem;">${element}</div>`);
});
