using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Erithacus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Erithacus.unclassified_Erithacus;

/// <summary>
/// Abstract class for unclassified Erithacus (no rank).
/// NCBI TaxId: 2623472
/// </summary>
public abstract class unclassified_Erithacus : Erithacus, Iunclassified_Erithacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Erithacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623472;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Erithacus";
}
