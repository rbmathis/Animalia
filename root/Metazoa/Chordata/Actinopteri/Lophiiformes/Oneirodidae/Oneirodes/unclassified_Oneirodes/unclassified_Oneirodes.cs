using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Oneirodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Oneirodes.unclassified_Oneirodes;

/// <summary>
/// Abstract class for unclassified Oneirodes (no rank).
/// NCBI TaxId: 2685425
/// </summary>
public abstract class unclassified_Oneirodes : Oneirodes, Iunclassified_Oneirodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oneirodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685425;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oneirodes";
}
