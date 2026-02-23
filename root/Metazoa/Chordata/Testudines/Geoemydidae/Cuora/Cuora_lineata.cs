namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cuora;

/// <summary>
/// Species: Cuora lineata
/// NCBI TaxId: 3147934
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuora_lineata : Cuora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuora lineata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuora_lineata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3147934;
}
