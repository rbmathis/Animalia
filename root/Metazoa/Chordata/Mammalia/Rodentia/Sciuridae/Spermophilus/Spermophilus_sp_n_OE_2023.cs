namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Spermophilus;

/// <summary>
/// Species: Spermophilus sp. n. OE-2023
/// NCBI TaxId: 3113799
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spermophilus_sp_n_OE_2023 : Spermophilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spermophilus sp. n. OE-2023";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spermophilus_sp_n_OE_2023";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3113799;
}
