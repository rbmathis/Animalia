namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amphiprion;

/// <summary>
/// Species: Amphiprion bicinctus x Amphiprion omanensis
/// NCBI TaxId: 1702347
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphiprion_bicinctus_x_Amphiprion_omanensis : Amphiprion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphiprion bicinctus x Amphiprion omanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphiprion_bicinctus_x_Amphiprion_omanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1702347;
}
