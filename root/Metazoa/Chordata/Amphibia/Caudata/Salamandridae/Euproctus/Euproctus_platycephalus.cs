namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Euproctus;

/// <summary>
/// Species: Euproctus platycephalus
/// NCBI TaxId: 30376
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Euproctus_platycephalus : Euproctus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Euproctus platycephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Euproctus_platycephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30376;
}
