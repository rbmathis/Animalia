namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Characidae_incertae_sedis.Dectobrycon;

/// <summary>
/// Interface defining characteristics of Dectobrycon (genus).
/// </summary>
public interface IDectobrycon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
