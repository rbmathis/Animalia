using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Setophaga;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Setophaga.unclassified_Setophaga;

/// <summary>
/// Abstract class for unclassified Setophaga (no rank).
/// NCBI TaxId: 2878428
/// </summary>
public abstract class unclassified_Setophaga : Setophaga, Iunclassified_Setophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Setophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878428;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Setophaga";
}
