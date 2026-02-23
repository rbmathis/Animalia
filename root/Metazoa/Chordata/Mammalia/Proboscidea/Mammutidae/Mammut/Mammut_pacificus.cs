namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Mammutidae.Mammut;

/// <summary>
/// Species: Mammut pacificus
/// NCBI TaxId: 3383205
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mammut_pacificus : Mammut
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mammut pacificus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mammut_pacificus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3383205;
}
