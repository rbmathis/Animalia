namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Parma;

/// <summary>
/// Species: Parma alboscapularis
/// NCBI TaxId: 2830205
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parma_alboscapularis : Parma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parma alboscapularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parma_alboscapularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2830205;
}
