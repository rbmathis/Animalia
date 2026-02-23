using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.unclassified_Gadidae;

/// <summary>
/// Abstract class for unclassified Gadidae (no rank).
/// NCBI TaxId: 2726985
/// </summary>
public abstract class unclassified_Gadidae : Gadidae, Iunclassified_Gadidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gadidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726985;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gadidae";
}
