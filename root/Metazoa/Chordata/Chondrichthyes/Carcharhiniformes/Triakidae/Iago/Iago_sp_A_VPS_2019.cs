namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Iago;

/// <summary>
/// Species: Iago sp. A VPS-2019
/// NCBI TaxId: 2605649
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Iago_sp_A_VPS_2019 : Iago
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Iago sp. A VPS-2019";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Iago_sp_A_VPS_2019";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2605649;
}
