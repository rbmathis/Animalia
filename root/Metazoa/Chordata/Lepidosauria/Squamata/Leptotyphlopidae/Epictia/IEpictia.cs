namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Epictia;

/// <summary>
/// Interface defining characteristics of Epictia (genus).
/// </summary>
public interface IEpictia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
