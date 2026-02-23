namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characiformes_incertae_sedis.Tarumaniidae.Tarumania;

/// <summary>
/// Interface defining characteristics of Tarumania (genus).
/// </summary>
public interface ITarumania
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
