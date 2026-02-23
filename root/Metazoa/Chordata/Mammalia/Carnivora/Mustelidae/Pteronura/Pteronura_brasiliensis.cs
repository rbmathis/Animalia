namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Pteronura;

/// <summary>
/// Species: Pteronura brasiliensis
/// NCBI TaxId: 9672
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pteronura_brasiliensis : Pteronura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pteronura brasiliensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pteronura_brasiliensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9672;
}
