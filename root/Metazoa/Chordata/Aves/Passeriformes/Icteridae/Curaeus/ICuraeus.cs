namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Curaeus;

/// <summary>
/// Interface defining characteristics of Curaeus (genus).
/// </summary>
public interface ICuraeus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
