using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Theloderma;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Theloderma.unclassified_Theloderma;

/// <summary>
/// Abstract class for unclassified Theloderma (no rank).
/// NCBI TaxId: 2618193
/// </summary>
public abstract class unclassified_Theloderma : Theloderma, Iunclassified_Theloderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Theloderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618193;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Theloderma";
}
