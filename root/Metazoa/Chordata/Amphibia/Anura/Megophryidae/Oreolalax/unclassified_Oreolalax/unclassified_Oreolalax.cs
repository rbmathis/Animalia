using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Oreolalax;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Oreolalax.unclassified_Oreolalax;

/// <summary>
/// Abstract class for unclassified Oreolalax (no rank).
/// NCBI TaxId: 2643083
/// </summary>
public abstract class unclassified_Oreolalax : Oreolalax, Iunclassified_Oreolalax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreolalax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643083;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreolalax";
}
