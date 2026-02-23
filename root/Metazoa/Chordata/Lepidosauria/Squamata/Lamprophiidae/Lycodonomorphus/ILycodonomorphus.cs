namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Lycodonomorphus;

/// <summary>
/// Interface defining characteristics of Lycodonomorphus (genus).
/// </summary>
public interface ILycodonomorphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
