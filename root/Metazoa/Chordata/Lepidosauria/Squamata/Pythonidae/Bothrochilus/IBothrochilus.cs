namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Bothrochilus;

/// <summary>
/// Interface defining characteristics of Bothrochilus (genus).
/// </summary>
public interface IBothrochilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
