namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mohoidae.Moho;

/// <summary>
/// Species: Moho braccatus
/// NCBI TaxId: 572106
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Moho_braccatus : Moho
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Moho braccatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Moho_braccatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 572106;
}
