using System;using R5T.T0064;


namespace R5T.Zografou
{[ServiceDefinitionMarker]
    public interface ITestingDataDirectoryNameConvention:IServiceDefinition
    {
        string GetTestingDataDirectoryName();
    }
}
