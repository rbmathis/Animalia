using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae.unclassified_Samaridae;

/// <summary>
/// Abstract class for unclassified Samaridae (no rank).
/// NCBI TaxId: 1780184
/// </summary>
public abstract class unclassified_Samaridae : Samaridae, Iunclassified_Samaridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Samaridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1780184;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Samaridae";
}
