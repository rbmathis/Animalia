using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas.unclassified_Anas;

/// <summary>
/// Abstract class for unclassified Anas (no rank).
/// NCBI TaxId: 2626389
/// </summary>
public abstract class unclassified_Anas : Anas, Iunclassified_Anas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626389;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anas";
}
