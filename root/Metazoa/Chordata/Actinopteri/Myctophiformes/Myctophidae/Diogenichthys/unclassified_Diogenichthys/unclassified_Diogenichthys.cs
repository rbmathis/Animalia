using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Diogenichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Diogenichthys.unclassified_Diogenichthys;

/// <summary>
/// Abstract class for unclassified Diogenichthys (no rank).
/// NCBI TaxId: 2685057
/// </summary>
public abstract class unclassified_Diogenichthys : Diogenichthys, Iunclassified_Diogenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diogenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685057;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diogenichthys";
}
