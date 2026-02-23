namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Eurostopodidae.Eurostopodus;

/// <summary>
/// Interface defining characteristics of Eurostopodus (genus).
/// </summary>
public interface IEurostopodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
