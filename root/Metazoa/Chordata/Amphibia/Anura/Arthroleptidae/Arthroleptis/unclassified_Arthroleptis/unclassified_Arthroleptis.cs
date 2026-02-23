using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Arthroleptis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Arthroleptis.unclassified_Arthroleptis;

/// <summary>
/// Abstract class for unclassified Arthroleptis (no rank).
/// NCBI TaxId: 2632511
/// </summary>
public abstract class unclassified_Arthroleptis : Arthroleptis, Iunclassified_Arthroleptis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arthroleptis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632511;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arthroleptis";
}
