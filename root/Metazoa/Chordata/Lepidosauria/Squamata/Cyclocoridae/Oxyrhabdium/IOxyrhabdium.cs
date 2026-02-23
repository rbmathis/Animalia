namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae.Oxyrhabdium;

/// <summary>
/// Interface defining characteristics of Oxyrhabdium (genus).
/// </summary>
public interface IOxyrhabdium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
