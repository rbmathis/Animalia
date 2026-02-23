using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Catostomidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Catostomidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2547734
/// </summary>
public abstract class Catostomidae_intergeneric_hybrids : Catostomidae, ICatostomidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catostomidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2547734;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Catostomidae_intergeneric_hybrids";
}
