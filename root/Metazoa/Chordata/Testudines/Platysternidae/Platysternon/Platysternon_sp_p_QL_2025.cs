namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Platysternidae.Platysternon;

/// <summary>
/// Species: Platysternon sp. p QL-2025
/// NCBI TaxId: 3452347
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platysternon_sp_p_QL_2025 : Platysternon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platysternon sp. p QL-2025";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platysternon_sp_p_QL_2025";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3452347;
}
