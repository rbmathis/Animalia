namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

/// <summary>
/// Species: Agama mossambica
/// NCBI TaxId: 175464
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agama_mossambica : Agama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agama mossambica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agama_mossambica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 175464;
}
