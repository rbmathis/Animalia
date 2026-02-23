using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Bathyraja;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Bathyraja.unclassified_Bathyraja;

/// <summary>
/// Abstract class for unclassified Bathyraja (no rank).
/// NCBI TaxId: 2639072
/// </summary>
public abstract class unclassified_Bathyraja : Bathyraja, Iunclassified_Bathyraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathyraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639072;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathyraja";
}
