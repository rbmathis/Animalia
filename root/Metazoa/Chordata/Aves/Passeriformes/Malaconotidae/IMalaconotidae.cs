namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae;

/// <summary>
/// Interface defining characteristics of Malaconotidae (family).
/// </summary>
public interface IMalaconotidae
{
    /// <inheritdoc />
    string FamilyName { get; }

    /// <inheritdoc />
    string[] FamilyCharacteristics { get; }

    /// <inheritdoc />
    bool HasNonRetractableClaws { get; }

    /// <inheritdoc />
    bool IsDigitigrade { get; }

    /// <inheritdoc />
    int FrontToeCount { get; }

    /// <inheritdoc />
    int HindToeCount { get; }

    /// <inheritdoc />
    string[] CommunicationMethods { get; }

}
