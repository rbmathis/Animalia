namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Stigmochelys;

/// <summary>
/// Interface defining characteristics of Stigmochelys (genus).
/// </summary>
public interface IStigmochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
