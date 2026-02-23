using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Hippoglossus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Hippoglossus.unclassified_Hippoglossus;

/// <summary>
/// Abstract class for unclassified Hippoglossus (no rank).
/// NCBI TaxId: 2631165
/// </summary>
public abstract class unclassified_Hippoglossus : Hippoglossus, Iunclassified_Hippoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hippoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631165;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hippoglossus";
}
