## C-Sharp(C#) Programming Learning

- C# and .NET framework(Windows) and .NET Core(cross platform)
- C# compiler and 中间代码(.dotnet)解析为机器码

```C#
// the compiler of C-Sharp:
// C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe

// 从 Developer PowerShell for VS 2022 终端打开 VSCode
// 或者将 csc 添加到系统环境变量中
code .

// 编译选项风格Microsoft, 想一想 MSVC(cl) 对于 C++ 的编译选项格式 ^_^
csc 01_hello.cs /out:hello.exe

// git and push to GitHub ---> main branch firstly
git remote add origin https://github.com/2694048168/CSharpLanguageLearning.git
git branch -M main
git push -u origin main
```


### C-Sharp 代码组织

```shell
# 1. 多文件组织代码，
# 注意 名字空间的引入和代码访问控制权限

# 2. .dll 动态库组织代码
# 注意 名字空间的引入和代码访问控制权限

# 3. NuGet 包管理器
# https://www.nuget.org/
```

### C-Sharp 图像界面开发

```shell
# 1. Windows 窗体应用程序, 利用 .NET framework,
# 这种方式有点类似 C++ 的 MFC 方式,

# 2. WPF 应用程序, 可以开发更加美观的界面程序,
```