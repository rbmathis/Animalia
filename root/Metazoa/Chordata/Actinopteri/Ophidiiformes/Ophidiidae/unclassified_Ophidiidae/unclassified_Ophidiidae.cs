using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.unclassified_Ophidiidae;

/// <summary>
/// Abstract class for unclassified Ophidiidae (no rank).
/// NCBI TaxId: 722547
/// </summary>
public abstract class unclassified_Ophidiidae : Ophidiidae, Iunclassified_Ophidiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophidiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722547;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophidiidae";
}
