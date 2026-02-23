using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Vipera;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Vipera.unclassified_Vipera;

/// <summary>
/// Abstract class for unclassified Vipera (no rank).
/// NCBI TaxId: 3674658
/// </summary>
public abstract class unclassified_Vipera : Vipera, Iunclassified_Vipera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Vipera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3674658;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Vipera";
}
