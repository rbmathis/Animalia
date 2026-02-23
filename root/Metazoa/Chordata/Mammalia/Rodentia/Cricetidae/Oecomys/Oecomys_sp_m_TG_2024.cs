namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys sp. m TG-2024
/// NCBI TaxId: 3112421
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_sp_m_TG_2024 : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys sp. m TG-2024";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_sp_m_TG_2024";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3112421;
}
