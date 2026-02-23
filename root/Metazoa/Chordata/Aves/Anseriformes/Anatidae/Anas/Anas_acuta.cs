namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas acuta
/// NCBI TaxId: 28680
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_acuta : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas acuta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_acuta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 28680;
}
