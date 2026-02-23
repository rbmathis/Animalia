namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella;

/// <summary>
/// Species: Rhinella cf. proboscidea
/// NCBI TaxId: 3090797
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinella_cf_proboscidea : Rhinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinella cf. proboscidea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinella_cf_proboscidea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3090797;
}
