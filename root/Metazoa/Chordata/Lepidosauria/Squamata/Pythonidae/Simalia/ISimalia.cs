namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Simalia;

/// <summary>
/// Interface defining characteristics of Simalia (genus).
/// </summary>
public interface ISimalia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
