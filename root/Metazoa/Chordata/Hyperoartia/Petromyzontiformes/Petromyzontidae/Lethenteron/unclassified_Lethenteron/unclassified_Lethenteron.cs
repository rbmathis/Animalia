using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Lethenteron;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Lethenteron.unclassified_Lethenteron;

/// <summary>
/// Abstract class for unclassified Lethenteron (no rank).
/// NCBI TaxId: 2647667
/// </summary>
public abstract class unclassified_Lethenteron : Lethenteron, Iunclassified_Lethenteron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lethenteron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647667;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lethenteron";
}
