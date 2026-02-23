using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluriformes_incertae_sedis;

/// <summary>
/// Abstract class for Siluriformes incertae sedis (no rank).
/// NCBI TaxId: 503189
/// </summary>
public abstract class Siluriformes_incertae_sedis : Siluriformes, ISiluriformes_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siluriformes incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503189;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Siluriformes_incertae_sedis";
}
