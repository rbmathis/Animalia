namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pelophylax;

/// <summary>
/// Species: Pelophylax cf. bedriagae 'Middle East'
/// NCBI TaxId: 909428
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelophylax_cf_bedriagae_Middle_East : Pelophylax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelophylax cf. bedriagae 'Middle East'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelophylax_cf_bedriagae_Middle_East";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 909428;
}
