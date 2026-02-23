namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Kinosternon;

/// <summary>
/// Species: Kinosternon stejnegeri
/// NCBI TaxId: 2268911
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinosternon_stejnegeri : Kinosternon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinosternon stejnegeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinosternon_stejnegeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2268911;
}
