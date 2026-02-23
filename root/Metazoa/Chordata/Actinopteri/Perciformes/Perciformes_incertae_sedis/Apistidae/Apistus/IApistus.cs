namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Apistidae.Apistus;

/// <summary>
/// Interface defining characteristics of Apistus (genus).
/// </summary>
public interface IApistus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
