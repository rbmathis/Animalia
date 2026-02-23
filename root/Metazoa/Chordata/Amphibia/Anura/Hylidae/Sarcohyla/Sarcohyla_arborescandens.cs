namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Sarcohyla;

/// <summary>
/// Species: Sarcohyla arborescandens
/// NCBI TaxId: 2018391
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sarcohyla_arborescandens : Sarcohyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sarcohyla arborescandens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sarcohyla_arborescandens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2018391;
}
