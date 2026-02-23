using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Tscherskia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Tscherskia.unclassified_Tscherskia;

/// <summary>
/// Abstract class for unclassified Tscherskia (no rank).
/// NCBI TaxId: 3122393
/// </summary>
public abstract class unclassified_Tscherskia : Tscherskia, Iunclassified_Tscherskia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tscherskia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3122393;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tscherskia";
}
