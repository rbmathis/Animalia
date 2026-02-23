namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neotoma;

/// <summary>
/// Species: Neotoma lepida
/// NCBI TaxId: 56216
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neotoma_lepida : Neotoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neotoma lepida";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neotoma_lepida";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56216;
}
