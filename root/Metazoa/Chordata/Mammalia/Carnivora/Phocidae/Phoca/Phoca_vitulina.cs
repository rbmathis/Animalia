namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Phoca;

/// <summary>
/// Species: Phoca vitulina
/// NCBI TaxId: 9720
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phoca_vitulina : Phoca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phoca vitulina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phoca_vitulina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9720;
}
