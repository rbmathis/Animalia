namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Lissotis;

/// <summary>
/// Species: Lissotis melanogaster
/// NCBI TaxId: 172682
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lissotis_melanogaster : Lissotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lissotis melanogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lissotis_melanogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 172682;
}
