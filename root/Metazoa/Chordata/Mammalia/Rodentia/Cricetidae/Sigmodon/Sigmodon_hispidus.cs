namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Sigmodon;

/// <summary>
/// Species: Sigmodon hispidus
/// NCBI TaxId: 42415
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sigmodon_hispidus : Sigmodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sigmodon hispidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sigmodon_hispidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42415;
}
