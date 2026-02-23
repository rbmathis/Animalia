namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Nyctimantis;

/// <summary>
/// Species: Nyctimantis rugiceps
/// NCBI TaxId: 318403
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctimantis_rugiceps : Nyctimantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctimantis rugiceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctimantis_rugiceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318403;
}
