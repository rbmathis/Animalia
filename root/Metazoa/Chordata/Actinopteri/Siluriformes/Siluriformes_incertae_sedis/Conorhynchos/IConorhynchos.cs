namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluriformes_incertae_sedis.Conorhynchos;

/// <summary>
/// Interface defining characteristics of Conorhynchos (genus).
/// </summary>
public interface IConorhynchos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
