using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neotoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neotoma.unclassified_Neotoma;

/// <summary>
/// Abstract class for unclassified Neotoma (no rank).
/// NCBI TaxId: 2641678
/// </summary>
public abstract class unclassified_Neotoma : Neotoma, Iunclassified_Neotoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neotoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641678;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neotoma";
}
