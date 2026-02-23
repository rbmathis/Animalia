namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Homopus;

/// <summary>
/// Species: Homopus femoralis
/// NCBI TaxId: 285998
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Homopus_femoralis : Homopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Homopus femoralis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Homopus_femoralis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 285998;
}
