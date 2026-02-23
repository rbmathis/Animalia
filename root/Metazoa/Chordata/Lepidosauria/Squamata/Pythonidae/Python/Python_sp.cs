namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Python;

/// <summary>
/// Species: Python sp.
/// NCBI TaxId: 3064505
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Python_sp : Python
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Python sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Python_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3064505;
}
