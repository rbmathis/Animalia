namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Amblyrhynchus;

/// <summary>
/// Interface defining characteristics of Amblyrhynchus (genus).
/// </summary>
public interface IAmblyrhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
