namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Micrablepharus;

/// <summary>
/// Interface defining characteristics of Micrablepharus (genus).
/// </summary>
public interface IMicrablepharus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
