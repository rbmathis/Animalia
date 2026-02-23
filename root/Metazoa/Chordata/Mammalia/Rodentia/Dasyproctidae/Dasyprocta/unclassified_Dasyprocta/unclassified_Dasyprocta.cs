using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Dasyprocta;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Dasyprocta.unclassified_Dasyprocta;

/// <summary>
/// Abstract class for unclassified Dasyprocta (no rank).
/// NCBI TaxId: 2647699
/// </summary>
public abstract class unclassified_Dasyprocta : Dasyprocta, Iunclassified_Dasyprocta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dasyprocta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647699;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dasyprocta";
}
