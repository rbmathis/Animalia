using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Melanocharacidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Melanocharacidium.unclassified_Melanocharacidium;

/// <summary>
/// Abstract class for unclassified Melanocharacidium (no rank).
/// NCBI TaxId: 2619434
/// </summary>
public abstract class unclassified_Melanocharacidium : Melanocharacidium, Iunclassified_Melanocharacidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanocharacidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619434;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanocharacidium";
}
