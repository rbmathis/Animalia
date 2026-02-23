namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae.Folia;

/// <summary>
/// Interface defining characteristics of Folia (genus).
/// </summary>
public interface IFolia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
