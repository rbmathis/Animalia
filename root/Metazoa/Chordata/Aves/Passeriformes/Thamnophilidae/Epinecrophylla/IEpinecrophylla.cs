namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Epinecrophylla;

/// <summary>
/// Interface defining characteristics of Epinecrophylla (genus).
/// </summary>
public interface IEpinecrophylla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
