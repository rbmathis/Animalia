namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Callimedusa;

/// <summary>
/// Interface defining characteristics of Callimedusa (genus).
/// </summary>
public interface ICallimedusa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
