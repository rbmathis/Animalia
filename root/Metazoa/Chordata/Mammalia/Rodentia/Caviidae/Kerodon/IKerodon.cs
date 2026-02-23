namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Kerodon;

/// <summary>
/// Interface defining characteristics of Kerodon (genus).
/// </summary>
public interface IKerodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
