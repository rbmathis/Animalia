using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Leptocharacidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Leptocharacidium.unclassified_Leptocharacidium;

/// <summary>
/// Abstract class for unclassified Leptocharacidium (no rank).
/// NCBI TaxId: 2835433
/// </summary>
public abstract class unclassified_Leptocharacidium : Leptocharacidium, Iunclassified_Leptocharacidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptocharacidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2835433;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptocharacidium";
}
