using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Prosymna;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Prosymna.unclassified_Prosymna;

/// <summary>
/// Abstract class for unclassified Prosymna (no rank).
/// NCBI TaxId: 2835283
/// </summary>
public abstract class unclassified_Prosymna : Prosymna, Iunclassified_Prosymna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Prosymna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2835283;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Prosymna";
}
