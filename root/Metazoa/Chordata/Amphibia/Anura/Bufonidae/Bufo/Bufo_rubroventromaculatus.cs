namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo;

/// <summary>
/// Species: Bufo rubroventromaculatus
/// NCBI TaxId: 3413437
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufo_rubroventromaculatus : Bufo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufo rubroventromaculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufo_rubroventromaculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3413437;
}
