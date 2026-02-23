using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Echis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Echis.unclassified_Echis;

/// <summary>
/// Abstract class for unclassified Echis (no rank).
/// NCBI TaxId: 2643535
/// </summary>
public abstract class unclassified_Echis : Echis, Iunclassified_Echis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Echis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643535;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Echis";
}
