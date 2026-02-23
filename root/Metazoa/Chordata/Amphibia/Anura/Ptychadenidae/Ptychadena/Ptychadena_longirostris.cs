namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Ptychadena;

/// <summary>
/// Species: Ptychadena longirostris
/// NCBI TaxId: 261670
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ptychadena_longirostris : Ptychadena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ptychadena longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ptychadena_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 261670;
}
