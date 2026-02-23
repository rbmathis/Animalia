namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Talpa;

/// <summary>
/// Species: Talpa occidentalis
/// NCBI TaxId: 50954
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Talpa_occidentalis : Talpa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Talpa occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Talpa_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 50954;
}
