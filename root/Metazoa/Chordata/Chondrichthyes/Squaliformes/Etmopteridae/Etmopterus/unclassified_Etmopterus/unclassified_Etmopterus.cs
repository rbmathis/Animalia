using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae.Etmopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae.Etmopterus.unclassified_Etmopterus;

/// <summary>
/// Abstract class for unclassified Etmopterus (no rank).
/// NCBI TaxId: 2620981
/// </summary>
public abstract class unclassified_Etmopterus : Etmopterus, Iunclassified_Etmopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Etmopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620981;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Etmopterus";
}
