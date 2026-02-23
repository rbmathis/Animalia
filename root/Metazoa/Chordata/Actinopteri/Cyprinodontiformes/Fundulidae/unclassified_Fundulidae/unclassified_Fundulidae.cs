using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fundulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fundulidae.unclassified_Fundulidae;

/// <summary>
/// Abstract class for unclassified Fundulidae (no rank).
/// NCBI TaxId: 1183129
/// </summary>
public abstract class unclassified_Fundulidae : Fundulidae, Iunclassified_Fundulidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fundulidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1183129;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fundulidae";
}
