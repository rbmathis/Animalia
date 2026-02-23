using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.unclassified_Falconiformes;

/// <summary>
/// Abstract class for unclassified Falconiformes (no rank).
/// NCBI TaxId: 771904
/// </summary>
public abstract class unclassified_Falconiformes : Falconiformes, Iunclassified_Falconiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Falconiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 771904;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Falconiformes";
}
