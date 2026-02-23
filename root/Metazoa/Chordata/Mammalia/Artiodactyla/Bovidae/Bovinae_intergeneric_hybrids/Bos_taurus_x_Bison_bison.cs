namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bovinae_intergeneric_hybrids;

/// <summary>
/// Species: Bos taurus x Bison bison
/// NCBI TaxId: 297284
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_taurus_x_Bison_bison : Bovinae_intergeneric_hybrids
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos taurus x Bison bison";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_taurus_x_Bison_bison";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 297284;
}
