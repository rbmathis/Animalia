using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anser;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anser.unclassified_Anser;

/// <summary>
/// Abstract class for unclassified Anser (no rank).
/// NCBI TaxId: 2639525
/// </summary>
public abstract class unclassified_Anser : Anser, Iunclassified_Anser
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anser";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639525;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anser";
}
