document.addEventListener('DOMContentLoaded', () => {
    const bookNowBtn = document.getElementById('bookNowBtn');
    if (bookNowBtn) {
        bookNowBtn.addEventListener('click', () => {
            alert('Bạn đã đặt tour thành công!');
        });
    }

    const images = ["~/style/img/image1.jpg", "~/style/img/image2.jpg", "~/style/img/image3.jpg", "~/style/img/image4.jpg"];
    let currentIndex = 0;

    const currentImage = document.getElementById('currentImage');

    window.nextImage = function() {
        currentIndex = (currentIndex + 1) % images.length;
        currentImage.src = images[currentIndex];
    };

    window.prevImage = function() {
        currentIndex = (currentIndex - 1 + images.length) % images.length;
        currentImage.src = images[currentIndex];
    };
});

