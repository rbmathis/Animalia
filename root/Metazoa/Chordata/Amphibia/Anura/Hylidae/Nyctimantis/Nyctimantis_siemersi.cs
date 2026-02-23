namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Nyctimantis;

/// <summary>
/// Species: Nyctimantis siemersi
/// NCBI TaxId: 318263
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctimantis_siemersi : Nyctimantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctimantis siemersi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctimantis_siemersi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318263;
}
