namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Fregetta;

/// <summary>
/// Species: Fregetta tropica
/// NCBI TaxId: 37073
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Fregetta_tropica : Fregetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Fregetta tropica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Fregetta_tropica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37073;
}
