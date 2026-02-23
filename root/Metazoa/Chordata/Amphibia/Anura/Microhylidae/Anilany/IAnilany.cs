namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Anilany;

/// <summary>
/// Interface defining characteristics of Anilany (genus).
/// </summary>
public interface IAnilany
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
