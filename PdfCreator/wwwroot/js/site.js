
const documentData = [];

$('#downloadButton').click(() => {
    $.ajax({
        type: 'POST',
        url: '/api/Documents/Create',
        data: JSON.stringify(documentData),
        contentType: 'application/json',
        success: (id) => {
            window.open(`/api/Documents/Download/${id}`);
        }
    });
});

$('#addElementButton').click(() => {
    var text = $('#elementText').val();
    $('#documentContainer').append(`<div>${text}</div>`);
    documentData.push(text);
});
