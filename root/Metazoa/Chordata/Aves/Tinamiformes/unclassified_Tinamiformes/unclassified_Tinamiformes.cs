using AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.unclassified_Tinamiformes;

/// <summary>
/// Abstract class for unclassified Tinamiformes (no rank).
/// NCBI TaxId: 1068483
/// </summary>
public abstract class unclassified_Tinamiformes : Tinamiformes, Iunclassified_Tinamiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tinamiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1068483;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tinamiformes";
}
