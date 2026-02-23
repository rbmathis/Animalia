namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sousa;

/// <summary>
/// Species: Sousa sp. AU002
/// NCBI TaxId: 468675
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sousa_sp_AU002 : Sousa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sousa sp. AU002";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sousa_sp_AU002";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 468675;
}
