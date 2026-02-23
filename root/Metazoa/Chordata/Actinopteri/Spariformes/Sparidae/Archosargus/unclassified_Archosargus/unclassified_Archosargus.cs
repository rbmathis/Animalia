using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Archosargus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Archosargus.unclassified_Archosargus;

/// <summary>
/// Abstract class for unclassified Archosargus (no rank).
/// NCBI TaxId: 2630540
/// </summary>
public abstract class unclassified_Archosargus : Archosargus, Iunclassified_Archosargus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Archosargus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630540;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Archosargus";
}
