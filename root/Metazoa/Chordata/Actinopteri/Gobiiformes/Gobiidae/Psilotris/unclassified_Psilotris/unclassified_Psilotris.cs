using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Psilotris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Psilotris.unclassified_Psilotris;

/// <summary>
/// Abstract class for unclassified Psilotris (no rank).
/// NCBI TaxId: 2685394
/// </summary>
public abstract class unclassified_Psilotris : Psilotris, Iunclassified_Psilotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psilotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685394;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psilotris";
}
