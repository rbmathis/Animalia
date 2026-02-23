namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Nycteridae.Nycteris;

/// <summary>
/// Species: Nycteris sp.
/// NCBI TaxId: 3242305
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nycteris_sp : Nycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nycteris sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nycteris_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3242305;
}
