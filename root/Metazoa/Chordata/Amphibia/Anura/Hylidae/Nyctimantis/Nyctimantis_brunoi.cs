namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Nyctimantis;

/// <summary>
/// Species: Nyctimantis brunoi
/// NCBI TaxId: 318254
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctimantis_brunoi : Nyctimantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctimantis brunoi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctimantis_brunoi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318254;
}
