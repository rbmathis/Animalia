namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Auchenoglanis;

/// <summary>
/// Species: Auchenoglanis occidentalis
/// NCBI TaxId: 390418
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Auchenoglanis_occidentalis : Auchenoglanis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Auchenoglanis occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Auchenoglanis_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 390418;
}
