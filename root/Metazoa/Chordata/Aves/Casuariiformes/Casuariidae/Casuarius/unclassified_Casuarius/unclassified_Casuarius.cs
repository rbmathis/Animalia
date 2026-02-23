using AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Casuariidae.Casuarius;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Casuariidae.Casuarius.unclassified_Casuarius;

/// <summary>
/// Abstract class for unclassified Casuarius (no rank).
/// NCBI TaxId: 2624260
/// </summary>
public abstract class unclassified_Casuarius : Casuarius, Iunclassified_Casuarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Casuarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624260;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Casuarius";
}
