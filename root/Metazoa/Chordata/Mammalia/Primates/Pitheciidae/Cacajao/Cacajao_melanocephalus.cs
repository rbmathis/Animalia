namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Cacajao;

/// <summary>
/// Species: Cacajao melanocephalus
/// NCBI TaxId: 70825
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacajao_melanocephalus : Cacajao
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacajao melanocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacajao_melanocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 70825;
}
