namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Tetracerus;

/// <summary>
/// Species: Tetracerus quadricornis
/// NCBI TaxId: 73823
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tetracerus_quadricornis : Tetracerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tetracerus quadricornis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tetracerus_quadricornis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 73823;
}
