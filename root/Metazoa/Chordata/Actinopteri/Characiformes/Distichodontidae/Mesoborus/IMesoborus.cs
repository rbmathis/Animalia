namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Mesoborus;

/// <summary>
/// Interface defining characteristics of Mesoborus (genus).
/// </summary>
public interface IMesoborus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
