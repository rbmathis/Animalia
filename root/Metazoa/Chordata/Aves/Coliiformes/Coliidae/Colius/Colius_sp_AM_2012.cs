namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae.Colius;

/// <summary>
/// Species: Colius sp. AM-2012
/// NCBI TaxId: 1207468
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colius_sp_AM_2012 : Colius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colius sp. AM-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colius_sp_AM_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1207468;
}
