namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardinella;

/// <summary>
/// Species: Sardinella atricauda
/// NCBI TaxId: 435221
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sardinella_atricauda : Sardinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sardinella atricauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sardinella_atricauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 435221;
}
