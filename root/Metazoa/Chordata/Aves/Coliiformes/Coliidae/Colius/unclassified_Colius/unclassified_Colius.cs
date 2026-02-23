using AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae.Colius;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae.Colius.unclassified_Colius;

/// <summary>
/// Abstract class for unclassified Colius (no rank).
/// NCBI TaxId: 2642200
/// </summary>
public abstract class unclassified_Colius : Colius, Iunclassified_Colius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Colius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642200;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Colius";
}
