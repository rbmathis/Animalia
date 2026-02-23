namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Martes;

/// <summary>
/// Species: Martes flavigula
/// NCBI TaxId: 74864
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Martes_flavigula : Martes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Martes flavigula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Martes_flavigula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 74864;
}
