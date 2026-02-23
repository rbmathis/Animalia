namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Blastocerus;

/// <summary>
/// Species: Blastocerus dichotomus
/// NCBI TaxId: 248133
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Blastocerus_dichotomus : Blastocerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Blastocerus dichotomus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Blastocerus_dichotomus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 248133;
}
