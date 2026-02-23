namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus;

/// <summary>
/// Species: Sciurus variegatoides
/// NCBI TaxId: 226875
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciurus_variegatoides : Sciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciurus variegatoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciurus_variegatoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 226875;
}
