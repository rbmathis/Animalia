namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lyrurus;

/// <summary>
/// Interface defining characteristics of Lyrurus (genus).
/// </summary>
public interface ILyrurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
