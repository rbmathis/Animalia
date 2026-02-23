namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Naja;

/// <summary>
/// Species: Naja cf. nigricollis
/// NCBI TaxId: 409858
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naja_cf_nigricollis : Naja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naja cf. nigricollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naja_cf_nigricollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 409858;
}
