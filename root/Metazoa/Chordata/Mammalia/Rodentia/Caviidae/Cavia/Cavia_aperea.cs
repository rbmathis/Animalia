namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Cavia;

/// <summary>
/// Species: Cavia aperea
/// NCBI TaxId: 37548
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cavia_aperea : Cavia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cavia aperea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cavia_aperea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37548;
}
