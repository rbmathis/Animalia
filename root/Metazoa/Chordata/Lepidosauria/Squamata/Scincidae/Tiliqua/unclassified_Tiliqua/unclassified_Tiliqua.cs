using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tiliqua;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tiliqua.unclassified_Tiliqua;

/// <summary>
/// Abstract class for unclassified Tiliqua (no rank).
/// NCBI TaxId: 3467927
/// </summary>
public abstract class unclassified_Tiliqua : Tiliqua, Iunclassified_Tiliqua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tiliqua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467927;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tiliqua";
}
