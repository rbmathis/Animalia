using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Myoprocta;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Myoprocta.unclassified_Myoprocta;

/// <summary>
/// Abstract class for unclassified Myoprocta (no rank).
/// NCBI TaxId: 2635579
/// </summary>
public abstract class unclassified_Myoprocta : Myoprocta, Iunclassified_Myoprocta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myoprocta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635579;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myoprocta";
}
