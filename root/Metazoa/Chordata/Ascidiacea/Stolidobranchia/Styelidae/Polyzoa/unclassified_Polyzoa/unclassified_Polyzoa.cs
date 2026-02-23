using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Polyzoa;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Polyzoa.unclassified_Polyzoa;

/// <summary>
/// Abstract class for unclassified Polyzoa (no rank).
/// NCBI TaxId: 2628772
/// </summary>
public abstract class unclassified_Polyzoa : Polyzoa, Iunclassified_Polyzoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polyzoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628772;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polyzoa";
}
