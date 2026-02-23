namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Alca;

/// <summary>
/// Species: Alca torda
/// NCBI TaxId: 28689
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alca_torda : Alca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alca torda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alca_torda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 28689;
}
