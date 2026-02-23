using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Microcharacidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Microcharacidium.unclassified_Microcharacidium;

/// <summary>
/// Abstract class for unclassified Microcharacidium (no rank).
/// NCBI TaxId: 2646612
/// </summary>
public abstract class unclassified_Microcharacidium : Microcharacidium, Iunclassified_Microcharacidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microcharacidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646612;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microcharacidium";
}
