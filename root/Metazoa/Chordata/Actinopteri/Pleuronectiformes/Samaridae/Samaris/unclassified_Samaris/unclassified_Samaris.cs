using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae.Samaris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae.Samaris.unclassified_Samaris;

/// <summary>
/// Abstract class for unclassified Samaris (no rank).
/// NCBI TaxId: 2620551
/// </summary>
public abstract class unclassified_Samaris : Samaris, Iunclassified_Samaris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Samaris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620551;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Samaris";
}
