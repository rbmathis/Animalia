namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Cardioglossa;

/// <summary>
/// Interface defining characteristics of Cardioglossa (genus).
/// </summary>
public interface ICardioglossa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
