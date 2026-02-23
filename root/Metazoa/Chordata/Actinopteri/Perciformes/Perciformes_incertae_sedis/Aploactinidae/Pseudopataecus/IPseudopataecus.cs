namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Pseudopataecus;

/// <summary>
/// Interface defining characteristics of Pseudopataecus (genus).
/// </summary>
public interface IPseudopataecus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
