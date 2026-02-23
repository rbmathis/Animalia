using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.unclassified_Leiognathidae;

/// <summary>
/// Abstract class for unclassified Leiognathidae (no rank).
/// NCBI TaxId: 1963717
/// </summary>
public abstract class unclassified_Leiognathidae : Leiognathidae, Iunclassified_Leiognathidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leiognathidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1963717;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leiognathidae";
}
