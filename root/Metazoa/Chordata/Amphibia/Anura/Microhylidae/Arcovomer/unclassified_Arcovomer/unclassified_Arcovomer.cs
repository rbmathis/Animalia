using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Arcovomer;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Arcovomer.unclassified_Arcovomer;

/// <summary>
/// Abstract class for unclassified Arcovomer (no rank).
/// NCBI TaxId: 3071699
/// </summary>
public abstract class unclassified_Arcovomer : Arcovomer, Iunclassified_Arcovomer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arcovomer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3071699;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arcovomer";
}
