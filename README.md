<p align="center">
<img height="300" src="https://user-images.githubusercontent.com/43035417/122687424-17337700-d21f-11eb-9d6b-26000d720291.jpg">
</p>

# Başlarken

devnot-mentor-back-end projesini çalıştırabilmek için bilgisayarınıza [.NET Core](https://dotnet.microsoft.com/download) yüklemelisiniz.

Projeyi klonlamak için.

```sh
$ git clone https://github.com/devnotcom/devnot-mentor-back-end.git
```

Development, Test ya da Production ortamında çalıştırmak için.

```sh
$  dotnet run --launch-profile Development
$  dotnet run --launch-profile Test
$  dotnet run --launch-profile Production
```

Publish alma işlemleri için.

```sh
$ dotnet publish
```

publish alma işleminden sonra uygun profili seçmek için ENV. değerinin karşılığı `Developemen`, `Test` ya da `Production` olmalıdır.

ENV. Key: DEVNOT_MENTOR_ENVIRONMENT

Örnek bir ENV. ataması: ***DEVNOT_MENTOR_ENVIRONMENT = production***



### API Projesi Ağaç Yapısı

```
📦 
└─ Devnot.Mentor.Api
   ├─ ActionFilters
   │  ├─ TokenAuthentication.cs
   │  └─ ValidateModelStateAttribute.cs
   ├─ Aspects
   │  └─ Autofac
   │     ├─ Exception
   │     │  └─ ExceptionHandlingAspect.cs
   │     └─ UnitOfWork
   │        └─ DevnotUnitOfWorkAspect.cs
   ├─ Common
   │  ├─ Response
   │  │  ├─ ApiResponse.cs
   │  │  ├─ ErrorApiResponse.cs
   │  │  └─ SuccessApiResponse.cs
   │  └─ ResultMessage.cs
   ├─ Configuration
   │  ├─ Context
   │  │  ├─ DevnotConfigurationContext.cs
   │  │  └─ IDevnotConfigurationContext.cs
   │  ├─ Environment
   │  │  ├─ EnvironmentService.cs
   │  │  └─ IEnvironmentService.cs
   │  ├─ appsettings.development.json
   │  ├─ appsettings.production.json
   │  └─ appsettings.test.json
   ├─ Controllers
   │  ├─ BaseController.cs
   │  ├─ MenteeController.cs
   │  ├─ MentorController.cs
   │  └─ UserController.cs
   ├─ CustomEntities
   │  ├─ Dto
   │  │  ├─ MenteeDto.cs
   │  │  ├─ MentorDto.cs
   │  │  └─ UserDto.cs
   │  ├─ Request
   │  │  ├─ MenteeRequest
   │  │  │  ├─ ApplyToMentorRequest.cs
   │  │  │  └─ CreateMenteeProfileRequest.cs
   │  │  ├─ MentorRequest
   │  │  │  └─ CreateMentorProfileRequest.cs
   │  │  └─ UserRequest
   │  │     ├─ CompleteRemindPasswordRequest.cs
   │  │     ├─ RegisterUserRequest.cs
   │  │     ├─ UpdatePasswordRequest.cs
   │  │     ├─ UpdateUserRequest.cs
   │  │     └─ UserLoginRequest.cs
   │  └─ Response
   │     └─ UserResponse
   │        └─ UserLoginResponse.cs
   ├─ DevnotMentor.Api.csproj
   ├─ Entities
   │  ├─ LinkType.cs
   │  ├─ Log.cs
   │  ├─ Mentee.cs
   │  ├─ MenteeAnswers.cs
   │  ├─ MenteeLinks.cs
   │  ├─ MenteeTags.cs
   │  ├─ Mentor.cs
   │  ├─ MentorApplications.cs
   │  ├─ MentorDBContext.cs
   │  ├─ MentorLinks.cs
   │  ├─ MentorMenteePairs.cs
   │  ├─ MentorQuestions.cs
   │  ├─ MentorTags.cs
   │  ├─ QuestionType.cs
   │  ├─ Tag.cs
   │  └─ User.cs
   ├─ Enums
   │  ├─ MentorApplicationStatus.cs
   │  └─ MentorMenteePairStatus.cs
   ├─ Helpers
   │  ├─ Extensions
   │  │  ├─ ClaimsExtensions.cs
   │  │  ├─ EnumExtensions.cs
   │  │  ├─ ObjectExtensions.cs
   │  │  └─ SwaggerExtensions.cs
   │  └─ MappingProfile.cs
   ├─ Program.cs
   ├─ Properties
   │  └─ launchSettings.json
   ├─ Repositories
   │  ├─ BaseRepository.cs
   │  ├─ Interfaces
   │  │  ├─ ILoggerRepository.cs
   │  │  ├─ IMenteeLinksRepository.cs
   │  │  ├─ IMenteeRepository.cs
   │  │  ├─ IMenteeTagsRepository.cs
   │  │  ├─ IMentorApplicationsRepository.cs
   │  │  ├─ IMentorLinksRepository.cs
   │  │  ├─ IMentorMenteePairsRepository.cs
   │  │  ├─ IMentorRepository.cs
   │  │  ├─ IMentorTagsRepository.cs
   │  │  ├─ IRepository.cs
   │  │  ├─ ITagRepository.cs
   │  │  └─ IUserRepository.cs
   │  ├─ LoggerRepository.cs
   │  ├─ MenteeLinksRepository.cs
   │  ├─ MenteeRepository.cs
   │  ├─ MenteeTagsRepository.cs
   │  ├─ MentorApplicationsRepository.cs
   │  ├─ MentorLinksRepository.cs
   │  ├─ MentorMenteePairsRepository.cs
   │  ├─ MentorRepository.cs
   │  ├─ MentorTagsRepository.cs
   │  ├─ TagRepository.cs
   │  └─ UserRepository.cs
   ├─ Services
   │  ├─ BaseService.cs
   │  ├─ Interfaces
   │  │  ├─ IMenteeService.cs
   │  │  ├─ IMentorService.cs
   │  │  └─ IUserService.cs
   │  ├─ MenteeService.cs
   │  ├─ MentorService.cs
   │  └─ UserService.cs
   ├─ Startup.cs
   ├─ Utilities
   │  ├─ Email
   │  │  ├─ IMailService.cs
   │  │  └─ SmtpMail
   │  │     └─ SmtpMailService.cs
   │  ├─ File
   │  │  ├─ FileResult.cs
   │  │  ├─ IFileService.cs
   │  │  └─ Local
   │  │     └─ LocalFileService.cs
   │  ├─ Interceptor
   │  │  ├─ AspectInterceptorSelector.cs
   │  │  ├─ Autofac
   │  │  │  ├─ Interception.cs
   │  │  │  └─ InterceptionBaseAttribute.cs
   │  │  └─ AutofacInterceptorModule.cs
   │  └─ Security
   │     ├─ Hash
   │     │  ├─ IHashService.cs
   │     │  └─ Sha256
   │     │     └─ Sha256HashService.cs
   │     └─ Token
   │        ├─ ITokenService.cs
   │        ├─ Jwt
   │        │  └─ JwtTokenService.cs
   │        ├─ ResolveTokenResult.cs
   │        └─ TokenInfo.cs
   ├─ appsettings.Development.json
   ├─ appsettings.json
   ├─ images
   │  └─ profile-images
   └─ web.config
```
