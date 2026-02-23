namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Meles;

/// <summary>
/// Species: Meles meles
/// NCBI TaxId: 9662
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Meles_meles : Meles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Meles meles";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Meles_meles";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9662;
}
