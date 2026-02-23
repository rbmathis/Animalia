namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Coluber;

/// <summary>
/// Species: Coluber sp.
/// NCBI TaxId: 1920182
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coluber_sp : Coluber
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coluber sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coluber_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1920182;
}
