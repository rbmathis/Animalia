using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Bothus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Bothus.unclassified_Bothus;

/// <summary>
/// Abstract class for unclassified Bothus (no rank).
/// NCBI TaxId: 2624723
/// </summary>
public abstract class unclassified_Bothus : Bothus, Iunclassified_Bothus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bothus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624723;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bothus";
}
