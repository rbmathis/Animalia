namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Zosterornis;

/// <summary>
/// Interface defining characteristics of Zosterornis (genus).
/// </summary>
public interface IZosterornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
