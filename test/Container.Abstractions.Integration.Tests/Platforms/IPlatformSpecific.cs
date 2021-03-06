namespace Container.Abstractions.Integration.Tests.Platforms
{
    public interface IPlatformSpecific
    {
        string TinyDockerImage { get; }

        string Shell { get; }

        string Echo { get; }

        string Touch { get; }

        string BindPath { get; }

        string TouchedFilePath { get; }

        string WorkingDirectory { get; }

        string[] PwdCommand();

        string[] CatCommand(string file);

        string[] EchoCommand(string message);

        string[] PrivilegedCommand();

        string[] ShellCommand(string command);

        string EnvVarFormat(string var);

        string IfExistsThenFormat(string @if, string then);
    }
}