<div align="center">
  <img alt="Availably" src="https://github.com/user-attachments/assets/70b2d9d9-8cab-4198-85ed-56840bd5944e" height="150" wdith="150" />
  <h1>Availably</h1>
  <p>An easy time scheduler for you and your friends!</p>
	<img alt="Static Badge" src="https://img.shields.io/badge/Language-C%23-green?style=flat">
 	<img alt="Static Badge" src="https://img.shields.io/badge/Framework-.NET-violet?style=flat">
  	<img alt="Static Badge" src="https://img.shields.io/badge/Database-Supabase-teal?style=flat">
</div>


# 🚀 Overview 

Availably ***will be*** an easy time scheduler so you and your friends can better structure hangouts. 
- Import or manually setup your calendar
- See your friends availability and decide better when to hangout
- No double bookings! 

**Please note: This project is currently under active development, and more exciting features are planned!**



# 🛠️ Technologies Used
- Language: C# 
- Framework: .NET (9.0)
- Database: PostgreSQL (Supabase)

# 🗺️ Project Roadmap

| Phase                     | Duration       | Goals & Deliverables                                      |
|---------------------------|----------------|------------------------------------------------------------|
| **Phase 1: Foundation**   | Weeks 1–4       | • Define domain model & use cases<br>• Scaffold solution<br>• EF Core schema + migrations<br>• `CreateSession` API & link-token generation |
| **Phase 2: Real-Time API**| Weeks 5–8       | • Implement SignalR hub (join/toggle)<br>• Hook up Application services<br>• Manual testing via Postman/console client<br>• Basic error handling |
| **Phase 3: Minimal Frontend**| Weeks 9–12  | • Initialize Next.js/React app<br>• Join session & toggle UI<br>• Listen for `ReceiveAvailabilityUpdate`<br>• Display aggregated free dates |
| **Phase 4: Polishing**    | Weeks 13–16     | • Refine UI/UX (Tailwind CSS)<br>• Session management (close/delete)<br>• Persistent link tokens & edge-case handling<br>• Basic unit/integration tests |
| **Phase 5: Extensions**   | Weeks 17–20+    | • Calendar integrations (Google/Outlook)<br>• (V2) Recurring availabilities<br>• Authentication (email/OAuth)<br>• CI/CD enhancements & monitoring |

# 📄 License

Distributed under the MIT License. See ```LICENSE``` for more information.
