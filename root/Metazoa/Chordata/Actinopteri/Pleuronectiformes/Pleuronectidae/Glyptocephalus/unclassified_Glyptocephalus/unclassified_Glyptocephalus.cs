using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Glyptocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Glyptocephalus.unclassified_Glyptocephalus;

/// <summary>
/// Abstract class for unclassified Glyptocephalus (no rank).
/// NCBI TaxId: 3084878
/// </summary>
public abstract class unclassified_Glyptocephalus : Glyptocephalus, Iunclassified_Glyptocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glyptocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3084878;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glyptocephalus";
}
