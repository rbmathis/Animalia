namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Mesoclemmys;

/// <summary>
/// Species: Mesoclemmys sp.
/// NCBI TaxId: 2866223
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesoclemmys_sp : Mesoclemmys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesoclemmys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesoclemmys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2866223;
}
