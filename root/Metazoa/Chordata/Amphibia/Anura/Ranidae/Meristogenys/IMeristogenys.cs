namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Meristogenys;

/// <summary>
/// Interface defining characteristics of Meristogenys (genus).
/// </summary>
public interface IMeristogenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
