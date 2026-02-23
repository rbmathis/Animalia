using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Macropodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Macropodus.unclassified_Macropodus;

/// <summary>
/// Abstract class for unclassified Macropodus (no rank).
/// NCBI TaxId: 2905694
/// </summary>
public abstract class unclassified_Macropodus : Macropodus, Iunclassified_Macropodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macropodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2905694;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macropodus";
}
