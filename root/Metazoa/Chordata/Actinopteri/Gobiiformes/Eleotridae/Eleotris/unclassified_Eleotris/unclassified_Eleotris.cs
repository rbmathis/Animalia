using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Eleotris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Eleotris.unclassified_Eleotris;

/// <summary>
/// Abstract class for unclassified Eleotris (no rank).
/// NCBI TaxId: 2638467
/// </summary>
public abstract class unclassified_Eleotris : Eleotris, Iunclassified_Eleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638467;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eleotris";
}
