namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Pardofelis;

/// <summary>
/// Species: Pardofelis marmorata
/// NCBI TaxId: 61410
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pardofelis_marmorata : Pardofelis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pardofelis marmorata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pardofelis_marmorata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61410;
}
