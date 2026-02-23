namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla felixarabica
/// NCBI TaxId: 762737
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_felixarabica : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla felixarabica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_felixarabica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 762737;
}
