namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Python;

/// <summary>
/// Species: Python molurus
/// NCBI TaxId: 51750
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Python_molurus : Python
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Python molurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Python_molurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51750;
}
