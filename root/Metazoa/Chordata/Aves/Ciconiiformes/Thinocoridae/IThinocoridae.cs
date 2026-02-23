namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Thinocoridae;

/// <summary>
/// Interface defining characteristics of Thinocoridae (family).
/// </summary>
public interface IThinocoridae
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
