namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus;

/// <summary>
/// Species: Sciurus sp.
/// NCBI TaxId: 48669
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciurus_sp : Sciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciurus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciurus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48669;
}
