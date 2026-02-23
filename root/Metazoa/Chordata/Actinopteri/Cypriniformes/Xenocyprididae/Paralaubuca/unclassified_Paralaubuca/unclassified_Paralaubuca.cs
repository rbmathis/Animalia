using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Paralaubuca;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Paralaubuca.unclassified_Paralaubuca;

/// <summary>
/// Abstract class for unclassified Paralaubuca (no rank).
/// NCBI TaxId: 2677600
/// </summary>
public abstract class unclassified_Paralaubuca : Paralaubuca, Iunclassified_Paralaubuca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paralaubuca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677600;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paralaubuca";
}
