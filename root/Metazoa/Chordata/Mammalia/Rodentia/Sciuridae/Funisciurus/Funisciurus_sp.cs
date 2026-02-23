namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Funisciurus;

/// <summary>
/// Species: Funisciurus sp.
/// NCBI TaxId: 3056446
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Funisciurus_sp : Funisciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Funisciurus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Funisciurus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3056446;
}
