namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo;

/// <summary>
/// Species: Bufo sp. MS-2008
/// NCBI TaxId: 510497
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufo_sp_MS_2008 : Bufo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufo sp. MS-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufo_sp_MS_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 510497;
}
