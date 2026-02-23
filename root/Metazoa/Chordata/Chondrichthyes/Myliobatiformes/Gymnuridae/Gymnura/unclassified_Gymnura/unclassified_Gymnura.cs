using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Gymnuridae.Gymnura;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Gymnuridae.Gymnura.unclassified_Gymnura;

/// <summary>
/// Abstract class for unclassified Gymnura (no rank).
/// NCBI TaxId: 2640779
/// </summary>
public abstract class unclassified_Gymnura : Gymnura, Iunclassified_Gymnura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640779;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnura";
}
