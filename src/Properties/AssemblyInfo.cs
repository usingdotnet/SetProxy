using System.Reflection;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyTitle("SetProxy (Debug)")]
[assembly: AssemblyDescription("SetProxy (Debug)")]
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyProduct("SetProxy (Debug)")]
#else
[assembly: AssemblyTitle("SetProxy (Release)")]
[assembly: AssemblyDescription("SetProxy (Release)")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyProduct("SetProxy (Release)")]
#endif

[assembly: AssemblyCompany("")]
[assembly: AssemblyCopyright("Copyright © usingdotnet 2023")]
[assembly: AssemblyTrademark("")]

[assembly: ComVisible(false)]

//若要开始生成可本地化的应用程序，请
//<PropertyGroup> 中的 .csproj 文件中
//例如，如果您在源文件中使用的是美国英语，
//使用的是美国英语，请将 <UICulture> 设置为 en-US。  然后取消 
//对以下 NeutralResourceLanguage 特性的注释。  更新
//以下行中的“en-US”以匹配项目文件中的 UICulture 设置。

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


// 前3位来自根目录下的GitInfo.txt
[assembly: AssemblyVersion("1.0.0.3")]
[assembly: AssemblyFileVersion("1.0.0.3")]
[assembly: AssemblyInformationalVersion("1.0.0.3")]