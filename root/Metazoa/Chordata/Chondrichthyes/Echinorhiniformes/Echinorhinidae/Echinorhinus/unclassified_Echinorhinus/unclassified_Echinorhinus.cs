using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Echinorhiniformes.Echinorhinidae.Echinorhinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Echinorhiniformes.Echinorhinidae.Echinorhinus.unclassified_Echinorhinus;

/// <summary>
/// Abstract class for unclassified Echinorhinus (no rank).
/// NCBI TaxId: 2599785
/// </summary>
public abstract class unclassified_Echinorhinus : Echinorhinus, Iunclassified_Echinorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Echinorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2599785;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Echinorhinus";
}
