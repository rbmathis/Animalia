using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo.unclassified_Torpedo;

/// <summary>
/// Abstract class for unclassified Torpedo (no rank).
/// NCBI TaxId: 2599791
/// </summary>
public abstract class unclassified_Torpedo : Torpedo, Iunclassified_Torpedo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Torpedo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2599791;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Torpedo";
}
