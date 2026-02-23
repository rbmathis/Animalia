using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.Symphurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.Symphurus.unclassified_Symphurus;

/// <summary>
/// Abstract class for unclassified Symphurus (no rank).
/// NCBI TaxId: 2637373
/// </summary>
public abstract class unclassified_Symphurus : Symphurus, Iunclassified_Symphurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Symphurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637373;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Symphurus";
}
