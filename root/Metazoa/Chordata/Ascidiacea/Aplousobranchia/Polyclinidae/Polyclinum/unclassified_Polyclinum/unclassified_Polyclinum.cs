using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae.Polyclinum;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae.Polyclinum.unclassified_Polyclinum;

/// <summary>
/// Abstract class for unclassified Polyclinum (no rank).
/// NCBI TaxId: 2634400
/// </summary>
public abstract class unclassified_Polyclinum : Polyclinum, Iunclassified_Polyclinum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polyclinum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634400;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polyclinum";
}
