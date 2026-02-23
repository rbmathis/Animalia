using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchella.unclassified_Sternarchella;

/// <summary>
/// Abstract class for unclassified Sternarchella (no rank).
/// NCBI TaxId: 2623103
/// </summary>
public abstract class unclassified_Sternarchella : Sternarchella, Iunclassified_Sternarchella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sternarchella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623103;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sternarchella";
}
