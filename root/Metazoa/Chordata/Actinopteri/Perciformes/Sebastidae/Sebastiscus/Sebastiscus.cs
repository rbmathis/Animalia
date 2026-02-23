using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Sebastiscus;

/// <summary>
/// Abstract class for Sebastiscus (genus).
/// NCBI TaxId: 41445
/// </summary>
public abstract class Sebastiscus : Sebastidae, ISebastiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sebastiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 41445;

    /// <inheritdoc />
    public virtual string GenusName => "Sebastiscus";

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
