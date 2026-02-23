namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Boana;

/// <summary>
/// Species: Boana sp. Clade G
/// NCBI TaxId: 2594781
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Boana_sp_Clade_G : Boana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Boana sp. Clade G";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Boana_sp_Clade_G";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2594781;
}
