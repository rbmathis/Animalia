namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Cheloniidae_intergeneric_hybrids;

/// <summary>
/// Species: Caretta caretta x Eretmochelys imbricata
/// NCBI TaxId: 348576
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Caretta_caretta_x_Eretmochelys_imbricata : Cheloniidae_intergeneric_hybrids
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Caretta caretta x Eretmochelys imbricata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Caretta_caretta_x_Eretmochelys_imbricata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 348576;
}
