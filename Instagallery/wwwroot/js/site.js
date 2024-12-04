// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.querySelectorAll('.lightbox-trigger').forEach(item => {
    item.addEventListener('click', function (e) {
        e.preventDefault();
        const lightboxUrl = this.getAttribute('href');
        window.location.href = lightboxUrl;
    });
});
document.querySelector('.lightbox-container').addEventListener('click', function () {
    window.history.back(); // Close lightbox and return to previous page
});
