namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Erinaceus;

/// <summary>
/// Species: Erinaceus sp. 'Ito, Shizuoka'
/// NCBI TaxId: 743785
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Erinaceus_sp_Ito_Shizuoka : Erinaceus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Erinaceus sp. 'Ito, Shizuoka'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Erinaceus_sp_Ito_Shizuoka";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 743785;
}
