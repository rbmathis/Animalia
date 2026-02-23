using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Oreosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Oreosaurus.unclassified_Oreosaurus;

/// <summary>
/// Abstract class for unclassified Oreosaurus (no rank).
/// NCBI TaxId: 2636976
/// </summary>
public abstract class unclassified_Oreosaurus : Oreosaurus, Iunclassified_Oreosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636976;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreosaurus";
}
