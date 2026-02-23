namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Genetta;

/// <summary>
/// Species: Genetta angolensis
/// NCBI TaxId: 235200
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Genetta_angolensis : Genetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Genetta angolensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Genetta_angolensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 235200;
}
