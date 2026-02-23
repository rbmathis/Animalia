namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Tarsius;

/// <summary>
/// Species: Tarsius fuscus
/// NCBI TaxId: 1748400
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tarsius_fuscus : Tarsius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tarsius fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tarsius_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1748400;
}
