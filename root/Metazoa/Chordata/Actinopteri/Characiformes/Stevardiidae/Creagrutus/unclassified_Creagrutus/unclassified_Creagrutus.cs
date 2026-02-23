using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Creagrutus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Creagrutus.unclassified_Creagrutus;

/// <summary>
/// Abstract class for unclassified Creagrutus (no rank).
/// NCBI TaxId: 2602653
/// </summary>
public abstract class unclassified_Creagrutus : Creagrutus, Iunclassified_Creagrutus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Creagrutus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602653;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Creagrutus";
}
