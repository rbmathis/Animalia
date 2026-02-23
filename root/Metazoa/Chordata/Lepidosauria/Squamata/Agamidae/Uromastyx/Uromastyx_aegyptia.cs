namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Uromastyx;

/// <summary>
/// Species: Uromastyx aegyptia
/// NCBI TaxId: 103697
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Uromastyx_aegyptia : Uromastyx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Uromastyx aegyptia";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Uromastyx_aegyptia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103697;
}
