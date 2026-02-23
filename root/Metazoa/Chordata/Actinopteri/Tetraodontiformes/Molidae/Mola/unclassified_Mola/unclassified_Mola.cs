using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae.Mola;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae.Mola.unclassified_Mola;

/// <summary>
/// Abstract class for unclassified Mola (no rank).
/// NCBI TaxId: 2626050
/// </summary>
public abstract class unclassified_Mola : Mola, Iunclassified_Mola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626050;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mola";
}
