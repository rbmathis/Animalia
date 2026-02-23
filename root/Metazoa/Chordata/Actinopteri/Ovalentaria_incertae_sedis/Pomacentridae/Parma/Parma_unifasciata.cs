namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Parma;

/// <summary>
/// Species: Parma unifasciata
/// NCBI TaxId: 2879610
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parma_unifasciata : Parma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parma unifasciata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parma_unifasciata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2879610;
}
