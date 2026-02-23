namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax albicans
/// NCBI TaxId: 1573471
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_albicans : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax albicans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_albicans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1573471;
}
