namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Galerella;

/// <summary>
/// Species: Galerella pulverulenta
/// NCBI TaxId: 55052
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galerella_pulverulenta : Galerella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galerella pulverulenta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galerella_pulverulenta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55052;
}
