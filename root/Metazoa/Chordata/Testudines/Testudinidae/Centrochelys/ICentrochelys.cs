namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Centrochelys;

/// <summary>
/// Interface defining characteristics of Centrochelys (genus).
/// </summary>
public interface ICentrochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
