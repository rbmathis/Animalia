using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pelasgus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pelasgus.unclassified_Pelasgus;

/// <summary>
/// Abstract class for unclassified Pelasgus (no rank).
/// NCBI TaxId: 2633055
/// </summary>
public abstract class unclassified_Pelasgus : Pelasgus, Iunclassified_Pelasgus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pelasgus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633055;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pelasgus";
}
