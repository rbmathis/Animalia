using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Pterobunocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Pterobunocephalus.unclassified_Pterobunocephalus;

/// <summary>
/// Abstract class for unclassified Pterobunocephalus (no rank).
/// NCBI TaxId: 2643600
/// </summary>
public abstract class unclassified_Pterobunocephalus : Pterobunocephalus, Iunclassified_Pterobunocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pterobunocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643600;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pterobunocephalus";
}
