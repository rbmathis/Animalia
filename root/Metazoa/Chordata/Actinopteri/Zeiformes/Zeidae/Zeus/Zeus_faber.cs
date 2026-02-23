namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zeidae.Zeus;

/// <summary>
/// Species: Zeus faber
/// NCBI TaxId: 64108
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zeus_faber : Zeus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zeus faber";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zeus_faber";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 64108;
}
