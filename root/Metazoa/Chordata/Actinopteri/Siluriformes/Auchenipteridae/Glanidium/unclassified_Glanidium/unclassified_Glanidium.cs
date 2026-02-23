using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Glanidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Glanidium.unclassified_Glanidium;

/// <summary>
/// Abstract class for unclassified Glanidium (no rank).
/// NCBI TaxId: 2627998
/// </summary>
public abstract class unclassified_Glanidium : Glanidium, Iunclassified_Glanidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glanidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627998;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glanidium";
}
