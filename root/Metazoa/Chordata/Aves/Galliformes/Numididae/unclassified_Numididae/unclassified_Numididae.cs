using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae.unclassified_Numididae;

/// <summary>
/// Abstract class for unclassified Numididae (no rank).
/// NCBI TaxId: 2732810
/// </summary>
public abstract class unclassified_Numididae : Numididae, Iunclassified_Numididae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Numididae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2732810;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Numididae";
}
