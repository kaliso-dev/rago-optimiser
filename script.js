const menuToggle = document.querySelector(".menu-toggle");
const navLinks   = document.querySelector(".nav-links");

menuToggle.addEventListener("click", () => {
  const isOpen = navLinks.classList.toggle("active");
  menuToggle.classList.toggle("active"); // ajoute/retire le X
  menuToggle.setAttribute("aria-expanded", isOpen ? "true" : "false");
});
