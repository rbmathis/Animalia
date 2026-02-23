using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.unclassified_Soleidae;

/// <summary>
/// Abstract class for unclassified Soleidae (no rank).
/// NCBI TaxId: 1526594
/// </summary>
public abstract class unclassified_Soleidae : Soleidae, Iunclassified_Soleidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Soleidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1526594;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Soleidae";
}
