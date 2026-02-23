namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Muraenolepididae.Muraenolepis;

/// <summary>
/// Species: Muraenolepis sp.
/// NCBI TaxId: 3083420
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muraenolepis_sp : Muraenolepis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muraenolepis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muraenolepis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3083420;
}
