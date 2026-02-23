using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Brachyplatystoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Brachyplatystoma.unclassified_Brachyplatystoma;

/// <summary>
/// Abstract class for unclassified Brachyplatystoma (no rank).
/// NCBI TaxId: 2634640
/// </summary>
public abstract class unclassified_Brachyplatystoma : Brachyplatystoma, Iunclassified_Brachyplatystoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachyplatystoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634640;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachyplatystoma";
}
