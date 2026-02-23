using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.unclassified_Ichthyophiidae;

/// <summary>
/// Abstract class for unclassified Ichthyophiidae (no rank).
/// NCBI TaxId: 1120372
/// </summary>
public abstract class unclassified_Ichthyophiidae : Ichthyophiidae, Iunclassified_Ichthyophiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ichthyophiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1120372;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ichthyophiidae";
}
