namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Lithobates;

/// <summary>
/// Interface defining characteristics of Lithobates (genus).
/// </summary>
public interface ILithobates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
