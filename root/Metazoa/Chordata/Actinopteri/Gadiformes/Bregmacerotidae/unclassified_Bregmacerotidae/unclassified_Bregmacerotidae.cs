using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Bregmacerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Bregmacerotidae.unclassified_Bregmacerotidae;

/// <summary>
/// Abstract class for unclassified Bregmacerotidae (no rank).
/// NCBI TaxId: 1781081
/// </summary>
public abstract class unclassified_Bregmacerotidae : Bregmacerotidae, Iunclassified_Bregmacerotidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bregmacerotidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1781081;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bregmacerotidae";
}
