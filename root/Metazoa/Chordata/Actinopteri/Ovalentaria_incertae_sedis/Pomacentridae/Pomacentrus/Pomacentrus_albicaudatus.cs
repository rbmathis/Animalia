namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Pomacentrus;

/// <summary>
/// Species: Pomacentrus albicaudatus
/// NCBI TaxId: 646027
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pomacentrus_albicaudatus : Pomacentrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pomacentrus albicaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pomacentrus_albicaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 646027;
}
