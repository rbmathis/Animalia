using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Dolichamphilius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Dolichamphilius.unclassified_Dolichamphilius;

/// <summary>
/// Abstract class for unclassified Dolichamphilius (no rank).
/// NCBI TaxId: 2643565
/// </summary>
public abstract class unclassified_Dolichamphilius : Dolichamphilius, Iunclassified_Dolichamphilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dolichamphilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643565;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dolichamphilius";
}
