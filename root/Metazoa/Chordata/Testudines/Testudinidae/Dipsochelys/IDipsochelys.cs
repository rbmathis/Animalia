namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Dipsochelys;

/// <summary>
/// Interface defining characteristics of Dipsochelys (genus).
/// </summary>
public interface IDipsochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
