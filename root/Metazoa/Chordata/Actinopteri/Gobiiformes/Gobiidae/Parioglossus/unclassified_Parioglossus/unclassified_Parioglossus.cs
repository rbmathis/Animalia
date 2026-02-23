using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Parioglossus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Parioglossus.unclassified_Parioglossus;

/// <summary>
/// Abstract class for unclassified Parioglossus (no rank).
/// NCBI TaxId: 2648028
/// </summary>
public abstract class unclassified_Parioglossus : Parioglossus, Iunclassified_Parioglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parioglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648028;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parioglossus";
}
