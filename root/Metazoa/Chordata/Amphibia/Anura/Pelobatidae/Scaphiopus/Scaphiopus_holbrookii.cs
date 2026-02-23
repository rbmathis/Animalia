namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Scaphiopus;

/// <summary>
/// Species: Scaphiopus holbrookii
/// NCBI TaxId: 8435
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scaphiopus_holbrookii : Scaphiopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scaphiopus holbrookii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scaphiopus_holbrookii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8435;
}
