using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.unclassified_Bythitidae;

/// <summary>
/// Abstract class for unclassified Bythitidae (no rank).
/// NCBI TaxId: 2580973
/// </summary>
public abstract class unclassified_Bythitidae : Bythitidae, Iunclassified_Bythitidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bythitidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2580973;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bythitidae";
}
