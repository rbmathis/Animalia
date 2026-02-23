namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Pheucticus;

/// <summary>
/// Species: Pheucticus aureoventris
/// NCBI TaxId: 138929
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pheucticus_aureoventris : Pheucticus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pheucticus aureoventris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pheucticus_aureoventris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 138929;
}
