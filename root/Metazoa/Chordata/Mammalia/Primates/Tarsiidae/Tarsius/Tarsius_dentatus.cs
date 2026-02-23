namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Tarsius;

/// <summary>
/// Species: Tarsius dentatus
/// NCBI TaxId: 449501
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tarsius_dentatus : Tarsius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tarsius dentatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tarsius_dentatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 449501;
}
