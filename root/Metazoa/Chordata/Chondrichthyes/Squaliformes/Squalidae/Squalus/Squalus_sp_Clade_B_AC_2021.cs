namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus sp. Clade B AC-2021
/// NCBI TaxId: 2806211
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_sp_Clade_B_AC_2021 : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus sp. Clade B AC-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_sp_Clade_B_AC_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2806211;
}
