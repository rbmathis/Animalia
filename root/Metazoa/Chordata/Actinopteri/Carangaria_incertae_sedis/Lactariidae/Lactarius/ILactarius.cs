namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Lactariidae.Lactarius;

/// <summary>
/// Interface defining characteristics of Lactarius (genus).
/// </summary>
public interface ILactarius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
