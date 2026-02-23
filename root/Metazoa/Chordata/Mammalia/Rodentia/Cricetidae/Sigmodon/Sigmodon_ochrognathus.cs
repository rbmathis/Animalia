namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Sigmodon;

/// <summary>
/// Species: Sigmodon ochrognathus
/// NCBI TaxId: 56214
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sigmodon_ochrognathus : Sigmodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sigmodon ochrognathus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sigmodon_ochrognathus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56214;
}
