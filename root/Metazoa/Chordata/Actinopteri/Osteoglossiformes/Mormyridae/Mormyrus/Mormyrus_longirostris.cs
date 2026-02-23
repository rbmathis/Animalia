namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Mormyrus;

/// <summary>
/// Species: Mormyrus longirostris
/// NCBI TaxId: 2809730
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mormyrus_longirostris : Mormyrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mormyrus longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mormyrus_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2809730;
}
