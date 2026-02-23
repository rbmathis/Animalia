using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Rhinatrematidae.Epicrionops;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Rhinatrematidae.Epicrionops.unclassified_Epicrionops;

/// <summary>
/// Abstract class for unclassified Epicrionops (no rank).
/// NCBI TaxId: 2636744
/// </summary>
public abstract class unclassified_Epicrionops : Epicrionops, Iunclassified_Epicrionops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epicrionops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636744;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epicrionops";
}
