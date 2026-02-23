namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Tarsius;

/// <summary>
/// Species: Tarsius sp. FFA-2009a
/// NCBI TaxId: 662655
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tarsius_sp_FFA_2009a : Tarsius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tarsius sp. FFA-2009a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tarsius_sp_FFA_2009a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 662655;
}
