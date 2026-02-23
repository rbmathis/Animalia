namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Petrosaurus;

/// <summary>
/// Species: Petrosaurus repens
/// NCBI TaxId: 468931
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petrosaurus_repens : Petrosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petrosaurus repens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petrosaurus_repens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 468931;
}
