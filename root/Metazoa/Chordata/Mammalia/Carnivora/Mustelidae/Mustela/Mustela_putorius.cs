namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Species: Mustela putorius
/// NCBI TaxId: 9668
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustela_putorius : Mustela
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustela putorius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustela_putorius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9668;
}
