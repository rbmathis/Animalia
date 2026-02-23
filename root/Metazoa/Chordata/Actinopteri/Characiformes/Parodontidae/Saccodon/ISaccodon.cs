namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae.Saccodon;

/// <summary>
/// Interface defining characteristics of Saccodon (genus).
/// </summary>
public interface ISaccodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
