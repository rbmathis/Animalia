using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Cnemidophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Cnemidophorus.unclassified_Cnemidophorus;

/// <summary>
/// Abstract class for unclassified Cnemidophorus (no rank).
/// NCBI TaxId: 2884916
/// </summary>
public abstract class unclassified_Cnemidophorus : Cnemidophorus, Iunclassified_Cnemidophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cnemidophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2884916;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cnemidophorus";
}
