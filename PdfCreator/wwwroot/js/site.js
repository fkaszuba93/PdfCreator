// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$('#downloadButton').click(() => {
    // TODO
    window.open('/api/Documents/Download/test');
});

$('#addElementButton').click(() => {
    // TODO
    var text = $('#elementText').val();
    $('#documentContainer').append(`<div>${text}</div>`);
});
