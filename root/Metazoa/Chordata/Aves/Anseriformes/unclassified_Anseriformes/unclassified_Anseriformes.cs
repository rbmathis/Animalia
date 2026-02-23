using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.unclassified_Anseriformes;

/// <summary>
/// Abstract class for unclassified Anseriformes (no rank).
/// NCBI TaxId: 771893
/// </summary>
public abstract class unclassified_Anseriformes : Anseriformes, Iunclassified_Anseriformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anseriformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 771893;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anseriformes";
}
