using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Pogoniulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Pogoniulus.unclassified_Pogoniulus;

/// <summary>
/// Abstract class for unclassified Pogoniulus (no rank).
/// NCBI TaxId: 3056961
/// </summary>
public abstract class unclassified_Pogoniulus : Pogoniulus, Iunclassified_Pogoniulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pogoniulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3056961;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pogoniulus";
}
