using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae.Scopelengys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae.Scopelengys.unclassified_Scopelengys;

/// <summary>
/// Abstract class for unclassified Scopelengys (no rank).
/// NCBI TaxId: 2649743
/// </summary>
public abstract class unclassified_Scopelengys : Scopelengys, Iunclassified_Scopelengys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scopelengys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649743;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scopelengys";
}
