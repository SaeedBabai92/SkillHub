# SkillHub – Intelligent Learning Progress Tracker

**SkillHub** is a personal learning and skill-tracking web app built with **Blazor Server (.NET 8)**.  
It helps developers and students monitor their learning sessions, visualize progress, and receive **rule-based recommendations** — all **without AI** or paid APIs.

---

## 🎯 Features (MVP)
- **User Management** – Local login via ASP.NET Identity (SQLite)
- **Skills** – Create, edit, and track progress (0–100%)
- **Learning Sessions** – Log study time, notes, and related skills
- **Dashboard** – “Today learned”, weekly chart, heatmap, and insights
- **Recommendation Engine** – Simple rule logic (no AI)
- **Export** – CSV and Markdown (Notion/OneNote compatible)

---

## 🧩 Tech Stack
| Layer | Technology | Reason |
|--------|-------------|--------|
| UI / Frontend | Blazor Server (.NET 8) | Interactive, modern, single codebase |
| Styles | Tailwind CSS / Custom CSS | Lightweight and responsive |
| Database | SQLite (local), PostgreSQL (Render) | Free and easy to host |
| ORM | Entity Framework Core | Native .NET integration |
| Auth | ASP.NET Identity | Built-in and secure |
| Charts | ChartJS / ApexCharts (for Blazor) | Beautiful, open-source visuals |
| Localization | `.resx` files (fi/en/es) | Multilingual support |
| Hosting | Render .com | Free Tier compatible |
| Domain | skillhub.saeed.babai.fi | Integrated with personal portfolio |

---

## 🚀 Development Plan (Sprints)
1️⃣ **Sprint 1:** Project setup, EF Core, Identity, CRUD basics  
2️⃣ **Sprint 2:** Dashboard, charts, heatmap, styling  
3️⃣ **Sprint 3:** Rule engine & recommendations  
4️⃣ **Sprint 4:** Localization, PWA/Offline mode  
5️⃣ **Sprint 5:** Portfolio integration & public demo

---

## 🌐 Demo & Portfolio
- **Live Demo:** [https://skillhub.saeed.babai.fi](https://skillhub.saeed.babai.fi)
- **Portfolio:** [https://saeed.babai.fi](https://saeed.babai.fi)

---

## 📜 License
This project is open source under the MIT License.

---

> _SkillHub — empowering learners to track, visualize, and improve their skills._
