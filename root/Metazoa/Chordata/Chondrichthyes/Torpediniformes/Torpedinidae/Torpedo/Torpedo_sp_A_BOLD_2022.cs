namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo;

/// <summary>
/// Species: Torpedo sp. A BOLD-2022
/// NCBI TaxId: 2980738
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Torpedo_sp_A_BOLD_2022 : Torpedo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Torpedo sp. A BOLD-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Torpedo_sp_A_BOLD_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2980738;
}
