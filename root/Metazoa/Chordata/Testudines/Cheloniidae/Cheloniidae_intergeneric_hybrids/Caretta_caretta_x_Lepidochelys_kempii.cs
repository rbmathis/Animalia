namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Cheloniidae_intergeneric_hybrids;

/// <summary>
/// Species: Caretta caretta x Lepidochelys kempii
/// NCBI TaxId: 160228
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Caretta_caretta_x_Lepidochelys_kempii : Cheloniidae_intergeneric_hybrids
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Caretta caretta x Lepidochelys kempii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Caretta_caretta_x_Lepidochelys_kempii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 160228;
}
