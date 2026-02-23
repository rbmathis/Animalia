namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Catharus;

/// <summary>
/// Species: Catharus mexicanus
/// NCBI TaxId: 172408
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Catharus_mexicanus : Catharus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Catharus mexicanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Catharus_mexicanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 172408;
}
