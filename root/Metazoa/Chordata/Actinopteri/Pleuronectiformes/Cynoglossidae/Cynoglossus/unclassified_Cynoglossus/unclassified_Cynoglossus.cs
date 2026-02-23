using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.Cynoglossus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.Cynoglossus.unclassified_Cynoglossus;

/// <summary>
/// Abstract class for unclassified Cynoglossus (no rank).
/// NCBI TaxId: 2627121
/// </summary>
public abstract class unclassified_Cynoglossus : Cynoglossus, Iunclassified_Cynoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627121;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynoglossus";
}
