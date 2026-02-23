namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Myliobatis;

/// <summary>
/// Species: Myliobatis australis
/// NCBI TaxId: 334989
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myliobatis_australis : Myliobatis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myliobatis australis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myliobatis_australis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 334989;
}
