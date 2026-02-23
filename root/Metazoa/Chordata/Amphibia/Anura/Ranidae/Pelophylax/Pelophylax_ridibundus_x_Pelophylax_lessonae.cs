namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pelophylax;

/// <summary>
/// Species: Pelophylax ridibundus x Pelophylax lessonae
/// NCBI TaxId: 1183878
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelophylax_ridibundus_x_Pelophylax_lessonae : Pelophylax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelophylax ridibundus x Pelophylax lessonae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelophylax_ridibundus_x_Pelophylax_lessonae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1183878;
}
