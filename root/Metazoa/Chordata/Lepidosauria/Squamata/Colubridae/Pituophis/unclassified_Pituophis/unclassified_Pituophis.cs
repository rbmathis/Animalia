using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pituophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pituophis.unclassified_Pituophis;

/// <summary>
/// Abstract class for unclassified Pituophis (no rank).
/// NCBI TaxId: 2878426
/// </summary>
public abstract class unclassified_Pituophis : Pituophis, Iunclassified_Pituophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pituophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878426;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pituophis";
}
