namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

/// <summary>
/// Interface defining characteristics of Accipitridae (family).
/// </summary>
public interface IAccipitridae
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
