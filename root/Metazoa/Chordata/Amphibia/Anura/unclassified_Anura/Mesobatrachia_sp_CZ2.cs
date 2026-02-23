namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.unclassified_Anura;

/// <summary>
/// Species: Mesobatrachia sp. CZ2
/// NCBI TaxId: 1702410
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesobatrachia_sp_CZ2 : unclassified_Anura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesobatrachia sp. CZ2";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesobatrachia_sp_CZ2";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1702410;
}
