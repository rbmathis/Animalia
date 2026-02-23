namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Caretta;

/// <summary>
/// Species: Caretta caretta
/// NCBI TaxId: 8467
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Caretta_caretta : Caretta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Caretta caretta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Caretta_caretta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8467;
}
