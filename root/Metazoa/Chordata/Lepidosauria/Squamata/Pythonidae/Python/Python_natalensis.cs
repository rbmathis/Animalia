namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Python;

/// <summary>
/// Species: Python natalensis
/// NCBI TaxId: 1848768
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Python_natalensis : Python
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Python natalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Python_natalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1848768;
}
