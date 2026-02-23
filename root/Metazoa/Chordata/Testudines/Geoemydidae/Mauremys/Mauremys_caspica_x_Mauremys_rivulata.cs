namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Mauremys;

/// <summary>
/// Species: Mauremys caspica x Mauremys rivulata
/// NCBI TaxId: 483167
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mauremys_caspica_x_Mauremys_rivulata : Mauremys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mauremys caspica x Mauremys rivulata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mauremys_caspica_x_Mauremys_rivulata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 483167;
}
