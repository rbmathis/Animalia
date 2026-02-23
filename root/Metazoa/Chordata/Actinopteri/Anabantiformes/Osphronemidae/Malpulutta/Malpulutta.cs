using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Malpulutta;

/// <summary>
/// Abstract class for Malpulutta (genus).
/// NCBI TaxId: 209234
/// </summary>
public abstract class Malpulutta : Osphronemidae, IMalpulutta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malpulutta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209234;

    /// <inheritdoc />
    public virtual string GenusName => "Malpulutta";

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
