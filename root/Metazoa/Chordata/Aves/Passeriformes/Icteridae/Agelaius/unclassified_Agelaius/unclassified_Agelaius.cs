using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Agelaius;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Agelaius.unclassified_Agelaius;

/// <summary>
/// Abstract class for unclassified Agelaius (no rank).
/// NCBI TaxId: 2878763
/// </summary>
public abstract class unclassified_Agelaius : Agelaius, Iunclassified_Agelaius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Agelaius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878763;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Agelaius";
}
