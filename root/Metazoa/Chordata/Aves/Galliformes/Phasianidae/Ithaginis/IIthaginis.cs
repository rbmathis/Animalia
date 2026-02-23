namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Ithaginis;

/// <summary>
/// Interface defining characteristics of Ithaginis (genus).
/// </summary>
public interface IIthaginis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
