namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Callisaurus;

/// <summary>
/// Interface defining characteristics of Callisaurus (genus).
/// </summary>
public interface ICallisaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
