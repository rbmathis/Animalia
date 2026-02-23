namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Mauremys;

/// <summary>
/// Species: Mauremys reevesii x Mauremys mutica mutica
/// NCBI TaxId: 3569865
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mauremys_reevesii_x_Mauremys_mutica_mutica : Mauremys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mauremys reevesii x Mauremys mutica mutica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mauremys_reevesii_x_Mauremys_mutica_mutica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3569865;
}
