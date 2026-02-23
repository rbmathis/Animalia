using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Polysyncraton;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Polysyncraton.unclassified_Polysyncraton;

/// <summary>
/// Abstract class for unclassified Polysyncraton (no rank).
/// NCBI TaxId: 2633363
/// </summary>
public abstract class unclassified_Polysyncraton : Polysyncraton, Iunclassified_Polysyncraton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polysyncraton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633363;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polysyncraton";
}
