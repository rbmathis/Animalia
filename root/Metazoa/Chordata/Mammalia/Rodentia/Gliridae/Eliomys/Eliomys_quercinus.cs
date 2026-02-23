namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Eliomys;

/// <summary>
/// Species: Eliomys quercinus
/// NCBI TaxId: 53277
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eliomys_quercinus : Eliomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eliomys quercinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eliomys_quercinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 53277;
}
