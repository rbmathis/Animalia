using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Typhlobelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Typhlobelus.unclassified_Typhlobelus;

/// <summary>
/// Abstract class for unclassified Typhlobelus (no rank).
/// NCBI TaxId: 3136079
/// </summary>
public abstract class unclassified_Typhlobelus : Typhlobelus, Iunclassified_Typhlobelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Typhlobelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3136079;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Typhlobelus";
}
