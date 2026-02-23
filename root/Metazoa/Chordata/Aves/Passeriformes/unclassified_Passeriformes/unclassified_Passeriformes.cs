using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.unclassified_Passeriformes;

/// <summary>
/// Abstract class for unclassified Passeriformes (no rank).
/// NCBI TaxId: 771911
/// </summary>
public abstract class unclassified_Passeriformes : Passeriformes, Iunclassified_Passeriformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Passeriformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 771911;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Passeriformes";
}
