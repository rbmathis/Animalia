namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Platysmurus;

/// <summary>
/// Species: Platysmurus aterrimus
/// NCBI TaxId: 3044215
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platysmurus_aterrimus : Platysmurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platysmurus aterrimus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platysmurus_aterrimus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3044215;
}
