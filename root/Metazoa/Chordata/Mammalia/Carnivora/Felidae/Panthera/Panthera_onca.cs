namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Panthera;

/// <summary>
/// Species: Panthera onca
/// NCBI TaxId: 9690
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Panthera_onca : Panthera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Panthera onca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Panthera_onca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9690;
}
