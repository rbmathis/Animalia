namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Eryx;

/// <summary>
/// Interface defining characteristics of Eryx (genus).
/// </summary>
public interface IEryx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
