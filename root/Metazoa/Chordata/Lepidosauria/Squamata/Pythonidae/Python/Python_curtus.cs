namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Python;

/// <summary>
/// Species: Python curtus
/// NCBI TaxId: 143536
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Python_curtus : Python
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Python curtus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Python_curtus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143536;
}
