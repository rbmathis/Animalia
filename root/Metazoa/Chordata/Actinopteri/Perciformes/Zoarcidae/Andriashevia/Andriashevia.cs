using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Andriashevia;

/// <summary>
/// Abstract class for Andriashevia (genus).
/// NCBI TaxId: 1828473
/// </summary>
public abstract class Andriashevia : Zoarcidae, IAndriashevia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Andriashevia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1828473;

    /// <inheritdoc />
    public virtual string GenusName => "Andriashevia";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
