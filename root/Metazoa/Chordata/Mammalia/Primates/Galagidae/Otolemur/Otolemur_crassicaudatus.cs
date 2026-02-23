namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Otolemur;

/// <summary>
/// Species: Otolemur crassicaudatus
/// NCBI TaxId: 9463
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otolemur_crassicaudatus : Otolemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otolemur crassicaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otolemur_crassicaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9463;
}
