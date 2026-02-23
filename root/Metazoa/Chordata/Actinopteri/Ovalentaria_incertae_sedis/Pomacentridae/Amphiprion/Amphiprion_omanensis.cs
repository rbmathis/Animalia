namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amphiprion;

/// <summary>
/// Species: Amphiprion omanensis
/// NCBI TaxId: 229074
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphiprion_omanensis : Amphiprion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphiprion omanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphiprion_omanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 229074;
}
