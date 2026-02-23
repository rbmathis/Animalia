namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae.Praslinia;

/// <summary>
/// Interface defining characteristics of Praslinia (genus).
/// </summary>
public interface IPraslinia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
