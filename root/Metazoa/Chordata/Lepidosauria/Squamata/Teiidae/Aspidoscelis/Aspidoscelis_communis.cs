namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Aspidoscelis;

/// <summary>
/// Species: Aspidoscelis communis
/// NCBI TaxId: 873080
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aspidoscelis_communis : Aspidoscelis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aspidoscelis communis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aspidoscelis_communis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 873080;
}
