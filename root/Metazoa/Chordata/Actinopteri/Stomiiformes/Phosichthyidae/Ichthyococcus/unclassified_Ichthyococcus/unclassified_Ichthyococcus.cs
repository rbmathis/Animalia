using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Ichthyococcus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Ichthyococcus.unclassified_Ichthyococcus;

/// <summary>
/// Abstract class for unclassified Ichthyococcus (no rank).
/// NCBI TaxId: 3092679
/// </summary>
public abstract class unclassified_Ichthyococcus : Ichthyococcus, Iunclassified_Ichthyococcus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ichthyococcus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3092679;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ichthyococcus";
}
