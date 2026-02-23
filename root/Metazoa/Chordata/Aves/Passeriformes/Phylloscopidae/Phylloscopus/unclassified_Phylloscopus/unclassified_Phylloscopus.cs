using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae.Phylloscopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae.Phylloscopus.unclassified_Phylloscopus;

/// <summary>
/// Abstract class for unclassified Phylloscopus (no rank).
/// NCBI TaxId: 2614684
/// </summary>
public abstract class unclassified_Phylloscopus : Phylloscopus, Iunclassified_Phylloscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phylloscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2614684;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phylloscopus";
}
