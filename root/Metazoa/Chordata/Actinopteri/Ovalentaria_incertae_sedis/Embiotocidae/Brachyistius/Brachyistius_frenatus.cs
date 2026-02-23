namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Brachyistius;

/// <summary>
/// Species: Brachyistius frenatus
/// NCBI TaxId: 100188
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachyistius_frenatus : Brachyistius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachyistius frenatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachyistius_frenatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100188;
}
