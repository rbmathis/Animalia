using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Adolfus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Adolfus.unclassified_Adolfus;

/// <summary>
/// Abstract class for unclassified Adolfus (no rank).
/// NCBI TaxId: 2629872
/// </summary>
public abstract class unclassified_Adolfus : Adolfus, Iunclassified_Adolfus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Adolfus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629872;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Adolfus";
}
