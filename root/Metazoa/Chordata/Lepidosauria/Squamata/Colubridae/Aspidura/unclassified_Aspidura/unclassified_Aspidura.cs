using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Aspidura;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Aspidura.unclassified_Aspidura;

/// <summary>
/// Abstract class for unclassified Aspidura (no rank).
/// NCBI TaxId: 2639505
/// </summary>
public abstract class unclassified_Aspidura : Aspidura, Iunclassified_Aspidura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aspidura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639505;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aspidura";
}
