namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodytidae.Pelodytes;

/// <summary>
/// Species: Pelodytes cf. punctatus DSM-2004
/// NCBI TaxId: 288792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelodytes_cf_punctatus_DSM_2004 : Pelodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelodytes cf. punctatus DSM-2004";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelodytes_cf_punctatus_DSM_2004";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 288792;
}
