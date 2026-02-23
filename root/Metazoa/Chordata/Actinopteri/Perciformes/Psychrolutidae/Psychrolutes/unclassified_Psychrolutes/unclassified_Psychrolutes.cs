using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Psychrolutes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Psychrolutes.unclassified_Psychrolutes;

/// <summary>
/// Abstract class for unclassified Psychrolutes (no rank).
/// NCBI TaxId: 2624812
/// </summary>
public abstract class unclassified_Psychrolutes : Psychrolutes, Iunclassified_Psychrolutes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psychrolutes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624812;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psychrolutes";
}
