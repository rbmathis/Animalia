namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Chimaera;

/// <summary>
/// Species: Chimaera sp. C BOLD-2022
/// NCBI TaxId: 2980709
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chimaera_sp_C_BOLD_2022 : Chimaera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chimaera sp. C BOLD-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chimaera_sp_C_BOLD_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2980709;
}
