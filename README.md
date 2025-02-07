# **CI/CD för API-projekt i C#**


Detta repo innehåller ett API-projekt i C# där syftet är att implementera en komplett CI/CD-kedja med GitHub Actions och AWS Elastic Beanstalk. 
API:et har två endpoints för kryptering och avkryptering, där rövarspråket används som krypteringsmetod.

**Teknologier och arbetsflöde**
- CI/CD: GitHub Actions hanterar automatiska byggen, tester och deployment.
- Git Flow: Branch-struktur med main, development (dev) och feature-brancher, samt pull requests för kodhantering.
- AWS Elastic Beanstalk: API:et distribueras automatiskt vid varje release (merge till main).
- Enhetstester: Förbättrad kvalitetssäkring genom automatiska tester vid push till dev.
- FigJam-dokumentation: Visualisering av CI/CD-processen för en fullstack-app.

**Deployment**

Varje ändring som mergas till main triggar en automatiserad deployment till AWS Elastic Beanstalk.
