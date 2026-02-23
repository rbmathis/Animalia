namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Ambassis;

/// <summary>
/// Species: Ambassis sp. 'western'
/// NCBI TaxId: 1379494
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ambassis_sp_western : Ambassis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ambassis sp. 'western'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ambassis_sp_western";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1379494;
}
