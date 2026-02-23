using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Macrhybopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Macrhybopsis.unclassified_Macrhybopsis;

/// <summary>
/// Abstract class for unclassified Macrhybopsis (no rank).
/// NCBI TaxId: 2639517
/// </summary>
public abstract class unclassified_Macrhybopsis : Macrhybopsis, Iunclassified_Macrhybopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macrhybopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639517;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macrhybopsis";
}
