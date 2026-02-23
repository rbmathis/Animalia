using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pomatoschistus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pomatoschistus.Pomatoschistus_minutus_complex;

/// <summary>
/// Abstract class for Pomatoschistus minutus complex (no rank).
/// NCBI TaxId: 751929
/// </summary>
public abstract class Pomatoschistus_minutus_complex : Pomatoschistus, IPomatoschistus_minutus_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pomatoschistus minutus complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 751929;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Pomatoschistus_minutus_complex";
}
