using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.unclassified_Chiasmodontidae;

/// <summary>
/// Abstract class for unclassified Chiasmodontidae (no rank).
/// NCBI TaxId: 1091434
/// </summary>
public abstract class unclassified_Chiasmodontidae : Chiasmodontidae, Iunclassified_Chiasmodontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiasmodontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1091434;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiasmodontidae";
}
