namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Aspidoscelis;

/// <summary>
/// Species: Aspidoscelis maximus
/// NCBI TaxId: 122585
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aspidoscelis_maximus : Aspidoscelis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aspidoscelis maximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aspidoscelis_maximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 122585;
}
