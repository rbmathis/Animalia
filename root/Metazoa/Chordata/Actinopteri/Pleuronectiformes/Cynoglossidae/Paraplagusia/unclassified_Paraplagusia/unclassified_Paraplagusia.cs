using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.Paraplagusia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.Paraplagusia.unclassified_Paraplagusia;

/// <summary>
/// Abstract class for unclassified Paraplagusia (no rank).
/// NCBI TaxId: 2620754
/// </summary>
public abstract class unclassified_Paraplagusia : Paraplagusia, Iunclassified_Paraplagusia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paraplagusia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620754;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paraplagusia";
}
