using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae.unclassified_Pinguipedidae;

/// <summary>
/// Abstract class for unclassified Pinguipedidae (no rank).
/// NCBI TaxId: 3446942
/// </summary>
public abstract class unclassified_Pinguipedidae : Pinguipedidae, Iunclassified_Pinguipedidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pinguipedidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446942;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pinguipedidae";
}
