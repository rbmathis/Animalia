using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cheilinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cheilinus.unclassified_Cheilinus;

/// <summary>
/// Abstract class for unclassified Cheilinus (no rank).
/// NCBI TaxId: 2989895
/// </summary>
public abstract class unclassified_Cheilinus : Cheilinus, Iunclassified_Cheilinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cheilinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2989895;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cheilinus";
}
