namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Tor;

/// <summary>
/// Species: Tor sp. SKG-2012
/// NCBI TaxId: 1197686
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tor_sp_SKG_2012 : Tor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tor sp. SKG-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tor_sp_SKG_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1197686;
}
