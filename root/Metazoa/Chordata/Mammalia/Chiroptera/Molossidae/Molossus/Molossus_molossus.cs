namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Molossus;

/// <summary>
/// Species: Molossus molossus
/// NCBI TaxId: 27622
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Molossus_molossus : Molossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Molossus molossus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Molossus_molossus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27622;
}
