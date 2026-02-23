using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Rajella;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Rajella.unclassified_Rajella;

/// <summary>
/// Abstract class for unclassified Rajella (no rank).
/// NCBI TaxId: 2677605
/// </summary>
public abstract class unclassified_Rajella : Rajella, Iunclassified_Rajella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rajella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677605;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rajella";
}
