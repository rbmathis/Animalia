namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Cavia;

/// <summary>
/// Species: Cavia fulgida
/// NCBI TaxId: 717921
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cavia_fulgida : Cavia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cavia fulgida";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cavia_fulgida";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 717921;
}
