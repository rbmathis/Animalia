namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Acanthosaura;

/// <summary>
/// Species: Acanthosaura lepidogaster
/// NCBI TaxId: 118088
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acanthosaura_lepidogaster : Acanthosaura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acanthosaura lepidogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acanthosaura_lepidogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 118088;
}
