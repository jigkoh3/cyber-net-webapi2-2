# cyber-net-webapi
template of web api by ms .net technoloyies


วิธีการทำงาน
1. แก้ไข connectionString ใน PL.WebAPI --> web.config
2. สร้าง class model ใน DAL.Entity --> Model
3. สร้าง Model Binding ใน DAL.Data --> DataContext.cs
--4. สร้าง Service Interface ใน Bll.Service --> Interface>
--5. สร้าง Service Imprement  ใน Bll.Service
6. Config DI (Dependency Injection) ใน PL.WebAPI --> App-Start>UnityConfig.cs
--6.1 สร้าง Contoller API ใน PL.WebAPI --> Controllers
7. ทดสอบเรียกด้วย Postman
8. SIT กับ Front End
9. Deploy To Azure or Other Server