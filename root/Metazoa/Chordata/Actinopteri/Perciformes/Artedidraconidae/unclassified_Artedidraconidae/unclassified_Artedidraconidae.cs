using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae.unclassified_Artedidraconidae;

/// <summary>
/// Abstract class for unclassified Artedidraconidae (no rank).
/// NCBI TaxId: 947861
/// </summary>
public abstract class unclassified_Artedidraconidae : Artedidraconidae, Iunclassified_Artedidraconidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Artedidraconidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 947861;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Artedidraconidae";
}
