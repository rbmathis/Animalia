using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Platycephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Platycephalus.unclassified_Platycephalus;

/// <summary>
/// Abstract class for unclassified Platycephalus (no rank).
/// NCBI TaxId: 2634724
/// </summary>
public abstract class unclassified_Platycephalus : Platycephalus, Iunclassified_Platycephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platycephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634724;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platycephalus";
}
