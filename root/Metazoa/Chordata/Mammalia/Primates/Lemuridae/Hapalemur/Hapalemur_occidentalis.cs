namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Hapalemur;

/// <summary>
/// Species: Hapalemur occidentalis
/// NCBI TaxId: 867377
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hapalemur_occidentalis : Hapalemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hapalemur occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hapalemur_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867377;
}
