namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo;

/// <summary>
/// Species: Bufo sp. 138 YSS-2007
/// NCBI TaxId: 478980
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufo_sp_138_YSS_2007 : Bufo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufo sp. 138 YSS-2007";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufo_sp_138_YSS_2007";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 478980;
}
