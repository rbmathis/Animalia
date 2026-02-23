using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Tadorna;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Tadorna.unclassified_Tadorna;

/// <summary>
/// Abstract class for unclassified Tadorna (no rank).
/// NCBI TaxId: 3378261
/// </summary>
public abstract class unclassified_Tadorna : Tadorna, Iunclassified_Tadorna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tadorna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3378261;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tadorna";
}
