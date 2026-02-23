using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fundulidae.Fundulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fundulidae.Fundulus.unclassified_Fundulus;

/// <summary>
/// Abstract class for unclassified Fundulus (no rank).
/// NCBI TaxId: 2633965
/// </summary>
public abstract class unclassified_Fundulus : Fundulus, Iunclassified_Fundulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fundulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633965;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fundulus";
}
