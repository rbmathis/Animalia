namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Stenella;

/// <summary>
/// Species: Stenella sp. STC2
/// NCBI TaxId: 2588968
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stenella_sp_STC2 : Stenella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stenella sp. STC2";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stenella_sp_STC2";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2588968;
}
