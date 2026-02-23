using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Oreortyx;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Oreortyx.unclassified_Oreortyx;

/// <summary>
/// Abstract class for unclassified Oreortyx (no rank).
/// NCBI TaxId: 2878407
/// </summary>
public abstract class unclassified_Oreortyx : Oreortyx, Iunclassified_Oreortyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreortyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878407;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreortyx";
}
