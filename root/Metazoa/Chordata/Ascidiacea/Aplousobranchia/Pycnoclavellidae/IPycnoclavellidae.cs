namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Pycnoclavellidae;

/// <summary>
/// Interface defining characteristics of Pycnoclavellidae (family).
/// </summary>
public interface IPycnoclavellidae
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
