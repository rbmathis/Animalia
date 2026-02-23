using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Artediellus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Artediellus.unclassified_Artediellus;

/// <summary>
/// Abstract class for unclassified Artediellus (no rank).
/// NCBI TaxId: 2640559
/// </summary>
public abstract class unclassified_Artediellus : Artediellus, Iunclassified_Artediellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Artediellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640559;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Artediellus";
}
