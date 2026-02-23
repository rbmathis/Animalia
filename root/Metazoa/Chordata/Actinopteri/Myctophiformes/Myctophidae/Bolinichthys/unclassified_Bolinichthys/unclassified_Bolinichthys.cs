using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Bolinichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Bolinichthys.unclassified_Bolinichthys;

/// <summary>
/// Abstract class for unclassified Bolinichthys (no rank).
/// NCBI TaxId: 2622770
/// </summary>
public abstract class unclassified_Bolinichthys : Bolinichthys, Iunclassified_Bolinichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bolinichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622770;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bolinichthys";
}
