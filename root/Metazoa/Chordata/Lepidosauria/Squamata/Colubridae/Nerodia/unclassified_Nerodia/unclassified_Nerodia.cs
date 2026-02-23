using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Nerodia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Nerodia.unclassified_Nerodia;

/// <summary>
/// Abstract class for unclassified Nerodia (no rank).
/// NCBI TaxId: 2767334
/// </summary>
public abstract class unclassified_Nerodia : Nerodia, Iunclassified_Nerodia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nerodia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767334;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nerodia";
}
