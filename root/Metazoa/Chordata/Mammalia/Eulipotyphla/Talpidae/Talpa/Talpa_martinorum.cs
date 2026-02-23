namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Talpa;

/// <summary>
/// Species: Talpa martinorum
/// NCBI TaxId: 2306880
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Talpa_martinorum : Talpa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Talpa martinorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Talpa_martinorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2306880;
}
