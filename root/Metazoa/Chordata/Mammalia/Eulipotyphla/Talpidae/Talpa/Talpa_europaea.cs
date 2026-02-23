namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Talpa;

/// <summary>
/// Species: Talpa europaea
/// NCBI TaxId: 9375
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Talpa_europaea : Talpa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Talpa europaea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Talpa_europaea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9375;
}
