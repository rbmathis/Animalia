using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Dunckerocampus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Dunckerocampus.unclassified_Dunckerocampus;

/// <summary>
/// Abstract class for unclassified Dunckerocampus (no rank).
/// NCBI TaxId: 3397023
/// </summary>
public abstract class unclassified_Dunckerocampus : Dunckerocampus, Iunclassified_Dunckerocampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dunckerocampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3397023;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dunckerocampus";
}
