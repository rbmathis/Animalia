using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Characidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Characidium.unclassified_Characidium;

/// <summary>
/// Abstract class for unclassified Characidium (no rank).
/// NCBI TaxId: 2621020
/// </summary>
public abstract class unclassified_Characidium : Characidium, Iunclassified_Characidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Characidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621020;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Characidium";
}
