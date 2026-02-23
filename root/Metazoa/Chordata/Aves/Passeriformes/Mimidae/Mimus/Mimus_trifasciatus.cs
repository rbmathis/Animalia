namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Mimus;

/// <summary>
/// Species: Mimus trifasciatus
/// NCBI TaxId: 245847
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mimus_trifasciatus : Mimus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mimus trifasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mimus_trifasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 245847;
}
