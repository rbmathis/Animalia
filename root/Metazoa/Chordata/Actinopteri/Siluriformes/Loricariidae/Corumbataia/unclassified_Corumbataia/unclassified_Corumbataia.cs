using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Corumbataia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Corumbataia.unclassified_Corumbataia;

/// <summary>
/// Abstract class for unclassified Corumbataia (no rank).
/// NCBI TaxId: 2643549
/// </summary>
public abstract class unclassified_Corumbataia : Corumbataia, Iunclassified_Corumbataia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Corumbataia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643549;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Corumbataia";
}
