namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Rousettus;

/// <summary>
/// Species: Rousettus obliviosus
/// NCBI TaxId: 705079
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rousettus_obliviosus : Rousettus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rousettus obliviosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rousettus_obliviosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 705079;
}
