using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Parascorpaena;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Parascorpaena.unclassified_Parascorpaena;

/// <summary>
/// Abstract class for unclassified Parascorpaena (no rank).
/// NCBI TaxId: 2621111
/// </summary>
public abstract class unclassified_Parascorpaena : Parascorpaena, Iunclassified_Parascorpaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parascorpaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621111;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parascorpaena";
}
