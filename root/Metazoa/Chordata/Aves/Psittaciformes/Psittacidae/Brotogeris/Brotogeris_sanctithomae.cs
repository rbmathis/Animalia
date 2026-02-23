namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Brotogeris;

/// <summary>
/// Species: Brotogeris sanctithomae
/// NCBI TaxId: 671080
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brotogeris_sanctithomae : Brotogeris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brotogeris sanctithomae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brotogeris_sanctithomae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 671080;
}
