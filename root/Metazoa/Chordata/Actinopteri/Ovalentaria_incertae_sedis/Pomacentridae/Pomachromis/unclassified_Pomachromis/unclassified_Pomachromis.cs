using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Pomachromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Pomachromis.unclassified_Pomachromis;

/// <summary>
/// Abstract class for unclassified Pomachromis (no rank).
/// NCBI TaxId: 3397016
/// </summary>
public abstract class unclassified_Pomachromis : Pomachromis, Iunclassified_Pomachromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pomachromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3397016;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pomachromis";
}
