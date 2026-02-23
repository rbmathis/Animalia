namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae.Chaltenobatrachus;

/// <summary>
/// Interface defining characteristics of Chaltenobatrachus (genus).
/// </summary>
public interface IChaltenobatrachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
