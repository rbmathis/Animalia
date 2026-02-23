namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Daubentoniidae.Daubentonia;

/// <summary>
/// Interface defining characteristics of Daubentonia (genus).
/// </summary>
public interface IDaubentonia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
