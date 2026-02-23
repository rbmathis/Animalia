using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus.unclassified_Turdus;

/// <summary>
/// Abstract class for unclassified Turdus (no rank).
/// NCBI TaxId: 2805847
/// </summary>
public abstract class unclassified_Turdus : Turdus, Iunclassified_Turdus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Turdus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2805847;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Turdus";
}
