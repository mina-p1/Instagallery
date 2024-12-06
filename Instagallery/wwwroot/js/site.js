document.addEventListener("DOMContentLoaded", () => {
    const modal = document.getElementById("photoModal");

    // Ensure the modal is hidden on page load
    modal.style.display = "none";

    const modalImage = document.getElementById("modalImage");
    const photoTitle = document.getElementById("photoTitle");
    const photoDescription = document.getElementById("photoDescription");
    const closeModal = document.getElementById("closeModal");
    const prevButton = document.getElementById("prevPhoto");
    const nextButton = document.getElementById("nextPhoto");

    const photos = Array.from(document.querySelectorAll(".gallery-item"));
    let currentIndex = 0;

    const showModal = (index) => {
        const photo = photos[index];
        const imageSrc = photo.querySelector("img").src;
        const title = photo.getAttribute("data-title");
        const description = photo.getAttribute("data-description") || "No description available.";

        modalImage.src = imageSrc;
        photoTitle.textContent = title;
        photoDescription.textContent = description;

        modal.style.display = "flex";
        currentIndex = index;
    };

    photos.forEach((item, index) => {
        item.addEventListener("click", () => {
            showModal(index);
        });
    });

    closeModal.addEventListener("click", () => {
        modal.style.display = "none";
    });

    modal.addEventListener("click", (event) => {
        if (event.target === modal) {
            modal.style.display = "none";
        }
    });

    prevButton.addEventListener("click", () => {
        if (currentIndex > 0) {
            showModal(currentIndex - 1);
        }
    });

    nextButton.addEventListener("click", () => {
        if (currentIndex < photos.length - 1) {
            showModal(currentIndex + 1);
        }
    });

    document.addEventListener("keydown", (event) => {
        if (modal.style.display === "flex") {
            if (event.key === "ArrowLeft" && currentIndex > 0) {
                showModal(currentIndex - 1);
            } else if (event.key === "ArrowRight" && currentIndex < photos.length - 1) {
                showModal(currentIndex + 1);
            } else if (event.key === "Escape") {
                modal.style.display = "none";
            }
        }
    });


    


    
    
    
    
    

});
