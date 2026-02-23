using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Pelophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Pelophryne.unclassified_Pelophryne;

/// <summary>
/// Abstract class for unclassified Pelophryne (no rank).
/// NCBI TaxId: 2641689
/// </summary>
public abstract class unclassified_Pelophryne : Pelophryne, Iunclassified_Pelophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pelophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641689;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pelophryne";
}
