namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Cacajao;

/// <summary>
/// Species: Cacajao rubicundus
/// NCBI TaxId: 70927
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacajao_rubicundus : Cacajao
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacajao rubicundus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacajao_rubicundus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 70927;
}
