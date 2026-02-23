namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Astrochelys;

/// <summary>
/// Interface defining characteristics of Astrochelys (genus).
/// </summary>
public interface IAstrochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
