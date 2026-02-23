using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae.Conepatus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae.Conepatus.unclassified_Conepatus;

/// <summary>
/// Abstract class for unclassified Conepatus (no rank).
/// NCBI TaxId: 2629212
/// </summary>
public abstract class unclassified_Conepatus : Conepatus, Iunclassified_Conepatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Conepatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629212;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Conepatus";
}
