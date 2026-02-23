namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Larimus;

/// <summary>
/// Species: Larimus pacificus
/// NCBI TaxId: 1260530
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Larimus_pacificus : Larimus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Larimus pacificus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Larimus_pacificus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1260530;
}
