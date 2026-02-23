namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Cavia;

/// <summary>
/// Species: Cavia tschudii
/// NCBI TaxId: 143287
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cavia_tschudii : Cavia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cavia tschudii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cavia_tschudii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143287;
}
