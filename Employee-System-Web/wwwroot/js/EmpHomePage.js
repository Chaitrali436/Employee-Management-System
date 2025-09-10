document.addEventListener('DOMContentLoaded', function () {
    const loginModal = new bootstrap.Modal(document.getElementById('loginModal'));
    loginModal.show();
    const registerModal = new bootstrap.Modal(document.getElementById('registerModal'));

    // Switch to register modal
    document.getElementById('openRegister').addEventListener('click', function () {
        loginModal.hide();
        setTimeout(() => registerModal.show(), 300);
    });
    // Switch back to login modal
    document.getElementById('openLogin').addEventListener('click', function () {
        registerModal.hide();
        setTimeout(() => loginModal.show(), 300);
    });
    // Proceed to Step 2
    document.getElementById('proceedBtn')?.addEventListener('click', function () {
        document.getElementById('step1').style.display = 'none';
        document.getElementById('step2').style.display = 'block';
    });
});