namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Platymantis;

/// <summary>
/// Species: Platymantis indeprensus
/// NCBI TaxId: 1598016
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platymantis_indeprensus : Platymantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platymantis indeprensus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platymantis_indeprensus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1598016;
}
