namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Diplolaemus;

/// <summary>
/// Interface defining characteristics of Diplolaemus (genus).
/// </summary>
public interface IDiplolaemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
