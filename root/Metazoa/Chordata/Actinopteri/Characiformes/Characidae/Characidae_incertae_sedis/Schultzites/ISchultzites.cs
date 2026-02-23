namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Characidae_incertae_sedis.Schultzites;

/// <summary>
/// Interface defining characteristics of Schultzites (genus).
/// </summary>
public interface ISchultzites
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
