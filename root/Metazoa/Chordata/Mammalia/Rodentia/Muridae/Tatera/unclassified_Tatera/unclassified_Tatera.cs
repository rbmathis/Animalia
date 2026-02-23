using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tatera;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tatera.unclassified_Tatera;

/// <summary>
/// Abstract class for unclassified Tatera (no rank).
/// NCBI TaxId: 2640413
/// </summary>
public abstract class unclassified_Tatera : Tatera, Iunclassified_Tatera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tatera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640413;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tatera";
}
