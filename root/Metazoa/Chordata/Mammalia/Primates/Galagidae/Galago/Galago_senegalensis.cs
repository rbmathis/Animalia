namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Galago;

/// <summary>
/// Species: Galago senegalensis
/// NCBI TaxId: 9465
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galago_senegalensis : Galago
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galago senegalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galago_senegalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9465;
}
