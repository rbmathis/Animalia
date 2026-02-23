namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Tockus;

/// <summary>
/// Species: Tockus rufirostris
/// NCBI TaxId: 1303330
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tockus_rufirostris : Tockus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tockus rufirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tockus_rufirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1303330;
}
