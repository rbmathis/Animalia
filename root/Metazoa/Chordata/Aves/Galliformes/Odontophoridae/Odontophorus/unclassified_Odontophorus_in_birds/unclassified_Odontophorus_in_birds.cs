using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Odontophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Odontophorus.unclassified_Odontophorus_in_birds;

/// <summary>
/// Abstract class for unclassified Odontophorus (in: birds) (no rank).
/// NCBI TaxId: 2688735
/// </summary>
public abstract class unclassified_Odontophorus_in_birds : Odontophorus, Iunclassified_Odontophorus_in_birds
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odontophorus (in: birds)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688735;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odontophorus_in_birds";
}
