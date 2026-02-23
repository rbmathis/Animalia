using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Pariolius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Pariolius.unclassified_Pariolius;

/// <summary>
/// Abstract class for unclassified Pariolius (no rank).
/// NCBI TaxId: 3110734
/// </summary>
public abstract class unclassified_Pariolius : Pariolius, Iunclassified_Pariolius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pariolius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3110734;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pariolius";
}
