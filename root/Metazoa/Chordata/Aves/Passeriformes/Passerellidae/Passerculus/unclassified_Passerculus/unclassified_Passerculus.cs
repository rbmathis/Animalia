using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Passerculus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Passerculus.unclassified_Passerculus;

/// <summary>
/// Abstract class for unclassified Passerculus (no rank).
/// NCBI TaxId: 2878396
/// </summary>
public abstract class unclassified_Passerculus : Passerculus, Iunclassified_Passerculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Passerculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878396;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Passerculus";
}
