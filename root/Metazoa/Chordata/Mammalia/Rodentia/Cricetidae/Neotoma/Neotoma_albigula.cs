namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neotoma;

/// <summary>
/// Species: Neotoma albigula
/// NCBI TaxId: 42408
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neotoma_albigula : Neotoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neotoma albigula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neotoma_albigula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42408;
}
