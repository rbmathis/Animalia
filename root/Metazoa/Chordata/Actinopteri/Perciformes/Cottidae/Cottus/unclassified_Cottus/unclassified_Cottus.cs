using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottus.unclassified_Cottus;

/// <summary>
/// Abstract class for unclassified Cottus (no rank).
/// NCBI TaxId: 2644765
/// </summary>
public abstract class unclassified_Cottus : Cottus, Iunclassified_Cottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644765;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cottus";
}
