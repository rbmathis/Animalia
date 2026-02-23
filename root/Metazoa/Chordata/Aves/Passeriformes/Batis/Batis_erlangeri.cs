namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Batis;

/// <summary>
/// Species: Batis erlangeri
/// NCBI TaxId: 1002747
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Batis_erlangeri : Batis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Batis erlangeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Batis_erlangeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002747;
}
