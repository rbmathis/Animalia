namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus sp.
/// NCBI TaxId: 10095
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_sp : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10095;
}
