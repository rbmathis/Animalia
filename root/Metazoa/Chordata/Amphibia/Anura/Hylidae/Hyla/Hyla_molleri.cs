namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla molleri
/// NCBI TaxId: 565010
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_molleri : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla molleri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_molleri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 565010;
}
