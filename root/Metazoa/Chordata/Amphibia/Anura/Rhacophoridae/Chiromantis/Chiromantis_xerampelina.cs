namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Chiromantis;

/// <summary>
/// Species: Chiromantis xerampelina
/// NCBI TaxId: 39610
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chiromantis_xerampelina : Chiromantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chiromantis xerampelina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chiromantis_xerampelina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39610;
}
