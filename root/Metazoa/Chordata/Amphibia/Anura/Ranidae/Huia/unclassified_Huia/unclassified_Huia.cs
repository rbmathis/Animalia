using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Huia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Huia.unclassified_Huia;

/// <summary>
/// Abstract class for unclassified Huia (no rank).
/// NCBI TaxId: 2619999
/// </summary>
public abstract class unclassified_Huia : Huia, Iunclassified_Huia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Huia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619999;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Huia";
}
