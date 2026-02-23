namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Species: Mustela eversmannii
/// NCBI TaxId: 77149
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustela_eversmannii : Mustela
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustela eversmannii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustela_eversmannii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 77149;
}
