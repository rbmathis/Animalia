namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Hynobius;

/// <summary>
/// Species: Hynobius sp. Form-C
/// NCBI TaxId: 113394
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hynobius_sp_Form_C : Hynobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hynobius sp. Form-C";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hynobius_sp_Form_C";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 113394;
}
