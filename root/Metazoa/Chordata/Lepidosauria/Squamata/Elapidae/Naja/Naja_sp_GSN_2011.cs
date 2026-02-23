namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Naja;

/// <summary>
/// Species: Naja sp. GSN-2011
/// NCBI TaxId: 1118395
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naja_sp_GSN_2011 : Naja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naja sp. GSN-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naja_sp_GSN_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1118395;
}
