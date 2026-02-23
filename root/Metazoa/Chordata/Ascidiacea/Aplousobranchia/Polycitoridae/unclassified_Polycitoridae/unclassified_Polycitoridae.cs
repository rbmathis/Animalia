using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.unclassified_Polycitoridae;

/// <summary>
/// Abstract class for unclassified Polycitoridae (no rank).
/// NCBI TaxId: 2510252
/// </summary>
public abstract class unclassified_Polycitoridae : Polycitoridae, Iunclassified_Polycitoridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polycitoridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2510252;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polycitoridae";
}
