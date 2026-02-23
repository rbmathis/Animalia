using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Stercorariidae.Stercorarius;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Stercorariidae.Stercorarius.unclassified_Stercorarius;

/// <summary>
/// Abstract class for unclassified Stercorarius (no rank).
/// NCBI TaxId: 1380739
/// </summary>
public abstract class unclassified_Stercorarius : Stercorarius, Iunclassified_Stercorarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stercorarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1380739;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stercorarius";
}
