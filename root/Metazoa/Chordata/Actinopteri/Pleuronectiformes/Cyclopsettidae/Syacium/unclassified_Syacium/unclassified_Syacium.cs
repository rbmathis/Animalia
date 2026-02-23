using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Syacium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Syacium.unclassified_Syacium;

/// <summary>
/// Abstract class for unclassified Syacium (no rank).
/// NCBI TaxId: 2635665
/// </summary>
public abstract class unclassified_Syacium : Syacium, Iunclassified_Syacium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Syacium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635665;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Syacium";
}
