using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Howellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Howellidae.unclassified_Howellidae;

/// <summary>
/// Abstract class for unclassified Howellidae (no rank).
/// NCBI TaxId: 3230563
/// </summary>
public abstract class unclassified_Howellidae : Howellidae, Iunclassified_Howellidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Howellidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3230563;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Howellidae";
}
