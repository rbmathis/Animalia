namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amphiprion;

/// <summary>
/// Species: Amphiprion frenatus
/// NCBI TaxId: 80971
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphiprion_frenatus : Amphiprion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphiprion frenatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphiprion_frenatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 80971;
}
