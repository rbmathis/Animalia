using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Sebastapistes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Sebastapistes.unclassified_Sebastapistes;

/// <summary>
/// Abstract class for unclassified Sebastapistes (no rank).
/// NCBI TaxId: 2634061
/// </summary>
public abstract class unclassified_Sebastapistes : Sebastapistes, Iunclassified_Sebastapistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sebastapistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634061;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sebastapistes";
}
