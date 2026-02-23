using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.unclassified_Mugilidae;

/// <summary>
/// Abstract class for unclassified Mugilidae (no rank).
/// NCBI TaxId: 666127
/// </summary>
public abstract class unclassified_Mugilidae : Mugilidae, Iunclassified_Mugilidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mugilidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666127;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mugilidae";
}
