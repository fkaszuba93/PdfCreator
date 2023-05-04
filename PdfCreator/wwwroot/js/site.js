// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

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
    // TODO
    var text = $('#elementText').val();
    $('#documentContainer').append(`<div>${text}</div>`);
    documentData.push(text);
});
