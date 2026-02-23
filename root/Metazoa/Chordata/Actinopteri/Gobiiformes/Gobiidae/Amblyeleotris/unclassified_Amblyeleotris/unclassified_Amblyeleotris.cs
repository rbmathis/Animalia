using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblyeleotris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblyeleotris.unclassified_Amblyeleotris;

/// <summary>
/// Abstract class for unclassified Amblyeleotris (no rank).
/// NCBI TaxId: 2625624
/// </summary>
public abstract class unclassified_Amblyeleotris : Amblyeleotris, Iunclassified_Amblyeleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amblyeleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625624;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amblyeleotris";
}
