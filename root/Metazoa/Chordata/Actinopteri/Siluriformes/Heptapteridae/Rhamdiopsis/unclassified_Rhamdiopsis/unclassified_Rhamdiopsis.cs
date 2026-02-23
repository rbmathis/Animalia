using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Rhamdiopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Rhamdiopsis.unclassified_Rhamdiopsis;

/// <summary>
/// Abstract class for unclassified Rhamdiopsis (no rank).
/// NCBI TaxId: 2829557
/// </summary>
public abstract class unclassified_Rhamdiopsis : Rhamdiopsis, Iunclassified_Rhamdiopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhamdiopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2829557;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhamdiopsis";
}
