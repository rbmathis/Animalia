namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Pyxis;

/// <summary>
/// Interface defining characteristics of Pyxis (genus).
/// </summary>
public interface IPyxis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
