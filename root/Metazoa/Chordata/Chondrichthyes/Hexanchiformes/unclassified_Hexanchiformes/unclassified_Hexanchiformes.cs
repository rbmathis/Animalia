using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.unclassified_Hexanchiformes;

/// <summary>
/// Abstract class for unclassified Hexanchiformes (no rank).
/// NCBI TaxId: 794804
/// </summary>
public abstract class unclassified_Hexanchiformes : Hexanchiformes, Iunclassified_Hexanchiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hexanchiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 794804;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hexanchiformes";
}
