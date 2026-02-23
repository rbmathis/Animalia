namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Neobatrachus;

/// <summary>
/// Species: Neobatrachus pelobatoides
/// NCBI TaxId: 43531
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neobatrachus_pelobatoides : Neobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neobatrachus pelobatoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neobatrachus_pelobatoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43531;
}
