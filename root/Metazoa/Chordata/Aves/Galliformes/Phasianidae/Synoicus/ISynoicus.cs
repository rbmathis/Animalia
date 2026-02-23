namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Synoicus;

/// <summary>
/// Interface defining characteristics of Synoicus (genus).
/// </summary>
public interface ISynoicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
