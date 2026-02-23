namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Humerana;

/// <summary>
/// Interface defining characteristics of Humerana (genus).
/// </summary>
public interface IHumerana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
