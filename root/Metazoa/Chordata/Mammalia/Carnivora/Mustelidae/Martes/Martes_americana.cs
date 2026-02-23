namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Martes;

/// <summary>
/// Species: Martes americana
/// NCBI TaxId: 9660
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Martes_americana : Martes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Martes americana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Martes_americana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9660;
}
