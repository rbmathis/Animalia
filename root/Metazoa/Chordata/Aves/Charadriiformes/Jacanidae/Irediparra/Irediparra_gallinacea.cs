namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae.Irediparra;

/// <summary>
/// Species: Irediparra gallinacea
/// NCBI TaxId: 54506
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Irediparra_gallinacea : Irediparra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Irediparra gallinacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Irediparra_gallinacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 54506;
}
