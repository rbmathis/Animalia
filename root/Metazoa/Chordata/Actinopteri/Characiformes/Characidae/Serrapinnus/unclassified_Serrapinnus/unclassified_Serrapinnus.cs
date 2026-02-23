using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Serrapinnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Serrapinnus.unclassified_Serrapinnus;

/// <summary>
/// Abstract class for unclassified Serrapinnus (no rank).
/// NCBI TaxId: 2638259
/// </summary>
public abstract class unclassified_Serrapinnus : Serrapinnus, Iunclassified_Serrapinnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Serrapinnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638259;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Serrapinnus";
}
