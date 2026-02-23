using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Liophidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Liophidium.unclassified_Liophidium;

/// <summary>
/// Abstract class for unclassified Liophidium (no rank).
/// NCBI TaxId: 2635255
/// </summary>
public abstract class unclassified_Liophidium : Liophidium, Iunclassified_Liophidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liophidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635255;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liophidium";
}
