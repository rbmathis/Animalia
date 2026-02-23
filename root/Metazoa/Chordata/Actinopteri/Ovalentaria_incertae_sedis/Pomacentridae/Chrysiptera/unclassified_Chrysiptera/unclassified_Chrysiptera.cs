using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Chrysiptera;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Chrysiptera.unclassified_Chrysiptera;

/// <summary>
/// Abstract class for unclassified Chrysiptera (no rank).
/// NCBI TaxId: 3419098
/// </summary>
public abstract class unclassified_Chrysiptera : Chrysiptera, Iunclassified_Chrysiptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chrysiptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3419098;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chrysiptera";
}
