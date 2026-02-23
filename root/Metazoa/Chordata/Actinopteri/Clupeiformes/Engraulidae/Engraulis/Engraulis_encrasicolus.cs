namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Engraulis;

/// <summary>
/// Species: Engraulis encrasicolus
/// NCBI TaxId: 184585
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Engraulis_encrasicolus : Engraulis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Engraulis encrasicolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Engraulis_encrasicolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 184585;
}
