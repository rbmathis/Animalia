namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Parabembridae;

/// <summary>
/// Interface defining characteristics of Parabembridae (family).
/// </summary>
public interface IParabembridae
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
