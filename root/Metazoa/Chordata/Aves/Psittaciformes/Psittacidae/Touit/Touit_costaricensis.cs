namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Touit;

/// <summary>
/// Species: Touit costaricensis
/// NCBI TaxId: 2338449
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Touit_costaricensis : Touit
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Touit costaricensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Touit_costaricensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2338449;
}
