using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Megalodicopia;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Megalodicopia.unclassified_Megalodicopia;

/// <summary>
/// Abstract class for unclassified Megalodicopia (no rank).
/// NCBI TaxId: 3457304
/// </summary>
public abstract class unclassified_Megalodicopia : Megalodicopia, Iunclassified_Megalodicopia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megalodicopia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3457304;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megalodicopia";
}
