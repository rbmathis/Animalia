namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Aspidoscelis;

/// <summary>
/// Species: Aspidoscelis sp.
/// NCBI TaxId: 2878745
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aspidoscelis_sp : Aspidoscelis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aspidoscelis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aspidoscelis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2878745;
}
