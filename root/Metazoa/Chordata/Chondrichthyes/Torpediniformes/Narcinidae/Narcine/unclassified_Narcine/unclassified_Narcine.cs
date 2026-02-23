using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae.Narcine;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae.Narcine.unclassified_Narcine;

/// <summary>
/// Abstract class for unclassified Narcine (no rank).
/// NCBI TaxId: 2599789
/// </summary>
public abstract class unclassified_Narcine : Narcine, Iunclassified_Narcine
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Narcine";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2599789;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Narcine";
}
