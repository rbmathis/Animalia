namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Aromobates;

/// <summary>
/// Interface defining characteristics of Aromobates (genus).
/// </summary>
public interface IAromobates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
