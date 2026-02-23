namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amphiprion;

/// <summary>
/// Species: Amphiprion ocellaris x Amphiprion percula
/// NCBI TaxId: 1133050
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphiprion_ocellaris_x_Amphiprion_percula : Amphiprion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphiprion ocellaris x Amphiprion percula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphiprion_ocellaris_x_Amphiprion_percula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1133050;
}
