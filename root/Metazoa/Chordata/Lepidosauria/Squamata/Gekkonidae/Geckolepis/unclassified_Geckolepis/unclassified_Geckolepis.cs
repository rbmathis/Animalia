using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Geckolepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Geckolepis.unclassified_Geckolepis;

/// <summary>
/// Abstract class for unclassified Geckolepis (no rank).
/// NCBI TaxId: 2640440
/// </summary>
public abstract class unclassified_Geckolepis : Geckolepis, Iunclassified_Geckolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Geckolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640440;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Geckolepis";
}
