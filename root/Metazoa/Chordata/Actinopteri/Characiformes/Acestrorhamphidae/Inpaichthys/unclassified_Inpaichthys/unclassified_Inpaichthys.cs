using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Inpaichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Inpaichthys.unclassified_Inpaichthys;

/// <summary>
/// Abstract class for unclassified Inpaichthys (no rank).
/// NCBI TaxId: 3073155
/// </summary>
public abstract class unclassified_Inpaichthys : Inpaichthys, Iunclassified_Inpaichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Inpaichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3073155;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Inpaichthys";
}
