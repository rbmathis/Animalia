namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo;

/// <summary>
/// Species: Bufo japonicus
/// NCBI TaxId: 8387
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufo_japonicus : Bufo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufo japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufo_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8387;
}
