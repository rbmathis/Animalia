using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Perca;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Perca.unclassified_Perca;

/// <summary>
/// Abstract class for unclassified Perca (no rank).
/// NCBI TaxId: 2636757
/// </summary>
public abstract class unclassified_Perca : Perca, Iunclassified_Perca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Perca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636757;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Perca";
}
