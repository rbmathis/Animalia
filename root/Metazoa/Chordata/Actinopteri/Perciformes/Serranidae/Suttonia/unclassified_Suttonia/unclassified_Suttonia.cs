using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Suttonia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Suttonia.unclassified_Suttonia;

/// <summary>
/// Abstract class for unclassified Suttonia (no rank).
/// NCBI TaxId: 2677814
/// </summary>
public abstract class unclassified_Suttonia : Suttonia, Iunclassified_Suttonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Suttonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677814;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Suttonia";
}
