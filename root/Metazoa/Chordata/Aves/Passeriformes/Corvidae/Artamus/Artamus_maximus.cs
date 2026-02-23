namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Artamus;

/// <summary>
/// Species: Artamus maximus
/// NCBI TaxId: 1160893
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Artamus_maximus : Artamus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Artamus maximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Artamus_maximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1160893;
}
