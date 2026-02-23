using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Amphilius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Amphilius.unclassified_Amphilius;

/// <summary>
/// Abstract class for unclassified Amphilius (no rank).
/// NCBI TaxId: 2645894
/// </summary>
public abstract class unclassified_Amphilius : Amphilius, Iunclassified_Amphilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amphilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amphilius";
}
