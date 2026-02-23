using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Myospalax;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Myospalax.unclassified_Myospalax;

/// <summary>
/// Abstract class for unclassified Myospalax (no rank).
/// NCBI TaxId: 2644169
/// </summary>
public abstract class unclassified_Myospalax : Myospalax, Iunclassified_Myospalax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myospalax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644169;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myospalax";
}
