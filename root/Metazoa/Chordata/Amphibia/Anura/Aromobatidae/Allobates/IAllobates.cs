namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Allobates;

/// <summary>
/// Interface defining characteristics of Allobates (genus).
/// </summary>
public interface IAllobates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
