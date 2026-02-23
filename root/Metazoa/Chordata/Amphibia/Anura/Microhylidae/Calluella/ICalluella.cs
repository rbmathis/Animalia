namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Calluella;

/// <summary>
/// Interface defining characteristics of Calluella (genus).
/// </summary>
public interface ICalluella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
