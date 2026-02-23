namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tiliqua;

/// <summary>
/// Species: Tiliqua scincoides
/// NCBI TaxId: 71010
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tiliqua_scincoides : Tiliqua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tiliqua scincoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tiliqua_scincoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 71010;
}
