namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Enyalius;

/// <summary>
/// Interface defining characteristics of Enyalius (genus).
/// </summary>
public interface IEnyalius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
