using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Gastrotheca;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Gastrotheca.unclassified_Gastrotheca;

/// <summary>
/// Abstract class for unclassified Gastrotheca (no rank).
/// NCBI TaxId: 2648769
/// </summary>
public abstract class unclassified_Gastrotheca : Gastrotheca, Iunclassified_Gastrotheca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gastrotheca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648769;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gastrotheca";
}
