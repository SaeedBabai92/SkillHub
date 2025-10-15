// Teema + mobiilinav
(function () {
    // Teema: lue tallennettu tai aseta oletus 'dark'
    const html = document.documentElement;
    const saved = localStorage.getItem("theme");
    if (saved === "light" || saved === "dark") {
        html.dataset.theme = saved;
    } else {
        html.dataset.theme = "dark";
        localStorage.setItem("theme", "dark");
    }

    // Theme toggle
    const themeBtn = document.querySelector('[data-js="theme-toggle"]');
    if (themeBtn) {
        themeBtn.setAttribute("aria-pressed", String(html.dataset.theme === "dark" ? false : true));
        themeBtn.addEventListener("click", () => {
            const next = html.dataset.theme === "dark" ? "light" : "dark";
            html.dataset.theme = next;
            localStorage.setItem("theme", next);
            themeBtn.setAttribute("aria-pressed", String(next === "light"));
        });
    }

    // Mobiili-nav
    const toggle = document.querySelector('[data-js="nav-toggle"]');
    const panel = document.querySelector('[data-js="nav-panel"]');
    if (toggle && panel) {
        toggle.addEventListener('click', () => {
            const open = panel.classList.toggle('is-open');
            toggle.setAttribute('aria-expanded', String(open));
        });
    }
})();
