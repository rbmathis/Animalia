namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis reconditus
/// NCBI TaxId: 141900
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_reconditus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis reconditus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_reconditus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 141900;
}
