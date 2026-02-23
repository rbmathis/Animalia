namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Psilorhinus;

/// <summary>
/// Species: Psilorhinus morio
/// NCBI TaxId: 114089
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psilorhinus_morio : Psilorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psilorhinus morio";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psilorhinus_morio";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 114089;
}
