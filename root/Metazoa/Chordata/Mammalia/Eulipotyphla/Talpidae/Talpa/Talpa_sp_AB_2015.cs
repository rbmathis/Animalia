namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Talpa;

/// <summary>
/// Species: Talpa sp. AB-2015
/// NCBI TaxId: 1607694
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Talpa_sp_AB_2015 : Talpa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Talpa sp. AB-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Talpa_sp_AB_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1607694;
}
