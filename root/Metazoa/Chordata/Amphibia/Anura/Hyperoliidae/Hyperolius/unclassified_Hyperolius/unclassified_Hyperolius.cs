using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius.unclassified_Hyperolius;

/// <summary>
/// Abstract class for unclassified Hyperolius (no rank).
/// NCBI TaxId: 2643904
/// </summary>
public abstract class unclassified_Hyperolius : Hyperolius, Iunclassified_Hyperolius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hyperolius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643904;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hyperolius";
}
