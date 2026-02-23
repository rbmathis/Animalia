namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Sinomicrurus;

/// <summary>
/// Interface defining characteristics of Sinomicrurus (genus).
/// </summary>
public interface ISinomicrurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
