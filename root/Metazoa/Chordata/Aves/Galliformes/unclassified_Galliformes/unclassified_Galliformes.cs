using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.unclassified_Galliformes;

/// <summary>
/// Abstract class for unclassified Galliformes (no rank).
/// NCBI TaxId: 791198
/// </summary>
public abstract class unclassified_Galliformes : Galliformes, Iunclassified_Galliformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Galliformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 791198;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Galliformes";
}
