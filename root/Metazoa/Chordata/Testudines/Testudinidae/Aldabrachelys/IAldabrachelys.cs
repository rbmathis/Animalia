namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Aldabrachelys;

/// <summary>
/// Interface defining characteristics of Aldabrachelys (genus).
/// </summary>
public interface IAldabrachelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
