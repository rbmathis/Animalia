namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

/// <summary>
/// Species: Agama montana
/// NCBI TaxId: 175463
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agama_montana : Agama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agama montana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agama_montana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 175463;
}
