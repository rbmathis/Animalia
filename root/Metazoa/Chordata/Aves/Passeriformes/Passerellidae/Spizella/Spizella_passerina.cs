namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Spizella;

/// <summary>
/// Species: Spizella passerina
/// NCBI TaxId: 40210
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spizella_passerina : Spizella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spizella passerina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spizella_passerina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 40210;
}
