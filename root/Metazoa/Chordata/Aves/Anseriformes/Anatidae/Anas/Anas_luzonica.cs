namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas luzonica
/// NCBI TaxId: 75851
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_luzonica : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas luzonica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_luzonica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75851;
}
