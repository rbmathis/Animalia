namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Oninia;

/// <summary>
/// Interface defining characteristics of Oninia (genus).
/// </summary>
public interface IOninia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
