namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Andinosaura;

/// <summary>
/// Species: Andinosaura aurea
/// NCBI TaxId: 1962996
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Andinosaura_aurea : Andinosaura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Andinosaura aurea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Andinosaura_aurea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1962996;
}
