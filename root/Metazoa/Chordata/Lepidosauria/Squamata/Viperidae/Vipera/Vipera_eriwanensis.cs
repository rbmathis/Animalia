namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Vipera;

/// <summary>
/// Species: Vipera eriwanensis
/// NCBI TaxId: 796011
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vipera_eriwanensis : Vipera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vipera eriwanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vipera_eriwanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 796011;
}
