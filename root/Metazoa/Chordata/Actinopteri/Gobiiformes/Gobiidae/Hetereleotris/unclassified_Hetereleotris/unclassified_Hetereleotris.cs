using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Hetereleotris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Hetereleotris.unclassified_Hetereleotris;

/// <summary>
/// Abstract class for unclassified Hetereleotris (no rank).
/// NCBI TaxId: 2646556
/// </summary>
public abstract class unclassified_Hetereleotris : Hetereleotris, Iunclassified_Hetereleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hetereleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646556;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hetereleotris";
}
