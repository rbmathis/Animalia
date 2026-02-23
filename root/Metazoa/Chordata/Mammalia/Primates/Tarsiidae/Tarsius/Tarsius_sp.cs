namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Tarsius;

/// <summary>
/// Species: Tarsius sp.
/// NCBI TaxId: 30612
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tarsius_sp : Tarsius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tarsius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tarsius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30612;
}
