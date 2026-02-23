namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Cheloniidae_intergeneric_hybrids;

/// <summary>
/// Species: Eretmochelys imbricata x Lepidochelys olivacea
/// NCBI TaxId: 348575
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eretmochelys_imbricata_x_Lepidochelys_olivacea : Cheloniidae_intergeneric_hybrids
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eretmochelys imbricata x Lepidochelys olivacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eretmochelys_imbricata_x_Lepidochelys_olivacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 348575;
}
