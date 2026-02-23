using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenopeltidae.Xenopeltis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenopeltidae.Xenopeltis.unclassified_Xenopeltis;

/// <summary>
/// Abstract class for unclassified Xenopeltis (no rank).
/// NCBI TaxId: 2912609
/// </summary>
public abstract class unclassified_Xenopeltis : Xenopeltis, Iunclassified_Xenopeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenopeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2912609;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenopeltis";
}
