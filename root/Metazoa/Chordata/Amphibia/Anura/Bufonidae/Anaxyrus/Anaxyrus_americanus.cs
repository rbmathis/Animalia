namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Anaxyrus;

/// <summary>
/// Species: Anaxyrus americanus
/// NCBI TaxId: 8389
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anaxyrus_americanus : Anaxyrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anaxyrus americanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anaxyrus_americanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8389;
}
