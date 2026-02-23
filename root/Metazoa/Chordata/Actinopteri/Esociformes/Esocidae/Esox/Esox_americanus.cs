namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Esocidae.Esox;

/// <summary>
/// Species: Esox americanus
/// NCBI TaxId: 184450
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Esox_americanus : Esox
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Esox americanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Esox_americanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 184450;
}
