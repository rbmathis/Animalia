namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae.Bathochordaeus;

/// <summary>
/// Interface defining characteristics of Bathochordaeus (genus).
/// </summary>
public interface IBathochordaeus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
