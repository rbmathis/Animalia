namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Muriculus;

/// <summary>
/// Species: Muriculus imberbis
/// NCBI TaxId: 1465659
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muriculus_imberbis : Muriculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muriculus imberbis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muriculus_imberbis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1465659;
}
