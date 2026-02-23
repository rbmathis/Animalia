namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Mesoclemmys;

/// <summary>
/// Species: Mesoclemmys dahli
/// NCBI TaxId: 1234953
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesoclemmys_dahli : Mesoclemmys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesoclemmys dahli";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesoclemmys_dahli";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234953;
}
