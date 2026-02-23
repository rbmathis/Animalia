namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Tringa;

/// <summary>
/// Species: Tringa sp. PCE-2012
/// NCBI TaxId: 1219336
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tringa_sp_PCE_2012 : Tringa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tringa sp. PCE-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tringa_sp_PCE_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1219336;
}
