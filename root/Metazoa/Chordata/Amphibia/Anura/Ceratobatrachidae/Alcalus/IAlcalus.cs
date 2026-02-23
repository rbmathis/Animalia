namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Alcalus;

/// <summary>
/// Interface defining characteristics of Alcalus (genus).
/// </summary>
public interface IAlcalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
