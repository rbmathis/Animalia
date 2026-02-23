namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Plectrohyla;

/// <summary>
/// Species: Plectrohyla guatemalensis
/// NCBI TaxId: 317386
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plectrohyla_guatemalensis : Plectrohyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plectrohyla guatemalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plectrohyla_guatemalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 317386;
}
