namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Leptocottus;

/// <summary>
/// Species: Leptocottus armatus
/// NCBI TaxId: 214925
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptocottus_armatus : Leptocottus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptocottus armatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptocottus_armatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 214925;
}
