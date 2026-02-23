namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Cinnycerthia;

/// <summary>
/// Species: Cinnycerthia fulva
/// NCBI TaxId: 1314641
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cinnycerthia_fulva : Cinnycerthia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cinnycerthia fulva";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cinnycerthia_fulva";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1314641;
}
