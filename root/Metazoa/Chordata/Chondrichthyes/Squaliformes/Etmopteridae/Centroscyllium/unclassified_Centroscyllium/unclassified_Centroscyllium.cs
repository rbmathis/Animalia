using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae.Centroscyllium;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae.Centroscyllium.unclassified_Centroscyllium;

/// <summary>
/// Abstract class for unclassified Centroscyllium (no rank).
/// NCBI TaxId: 2619062
/// </summary>
public abstract class unclassified_Centroscyllium : Centroscyllium, Iunclassified_Centroscyllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Centroscyllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619062;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Centroscyllium";
}
