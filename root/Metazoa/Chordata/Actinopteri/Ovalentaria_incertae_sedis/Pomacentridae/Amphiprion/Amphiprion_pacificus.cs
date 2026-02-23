namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amphiprion;

/// <summary>
/// Species: Amphiprion pacificus
/// NCBI TaxId: 926444
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphiprion_pacificus : Amphiprion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphiprion pacificus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphiprion_pacificus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 926444;
}
