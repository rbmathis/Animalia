namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurus;

/// <summary>
/// Species: Sciurus meridionalis
/// NCBI TaxId: 1917017
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciurus_meridionalis : Sciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciurus meridionalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciurus_meridionalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1917017;
}
