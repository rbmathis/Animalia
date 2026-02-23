namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Deirochelys;

/// <summary>
/// Species: Deirochelys reticularia
/// NCBI TaxId: 158819
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Deirochelys_reticularia : Deirochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Deirochelys reticularia";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Deirochelys_reticularia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 158819;
}
