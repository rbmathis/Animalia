using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Montivipera;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Montivipera.unclassified_Montivipera;

/// <summary>
/// Abstract class for unclassified Montivipera (no rank).
/// NCBI TaxId: 2631834
/// </summary>
public abstract class unclassified_Montivipera : Montivipera, Iunclassified_Montivipera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Montivipera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631834;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Montivipera";
}
