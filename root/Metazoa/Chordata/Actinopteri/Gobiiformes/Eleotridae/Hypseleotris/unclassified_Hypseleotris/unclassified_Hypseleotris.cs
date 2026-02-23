using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Hypseleotris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Hypseleotris.unclassified_Hypseleotris;

/// <summary>
/// Abstract class for unclassified Hypseleotris (no rank).
/// NCBI TaxId: 2620911
/// </summary>
public abstract class unclassified_Hypseleotris : Hypseleotris, Iunclassified_Hypseleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypseleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620911;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypseleotris";
}
