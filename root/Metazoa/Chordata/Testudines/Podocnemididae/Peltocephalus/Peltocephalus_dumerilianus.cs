namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Peltocephalus;

/// <summary>
/// Species: Peltocephalus dumerilianus
/// NCBI TaxId: 329145
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peltocephalus_dumerilianus : Peltocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peltocephalus dumerilianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peltocephalus_dumerilianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 329145;
}
