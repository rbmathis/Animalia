namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Nyctimantis;

/// <summary>
/// Species: Nyctimantis galeata
/// NCBI TaxId: 2728946
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctimantis_galeata : Nyctimantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctimantis galeata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctimantis_galeata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2728946;
}
