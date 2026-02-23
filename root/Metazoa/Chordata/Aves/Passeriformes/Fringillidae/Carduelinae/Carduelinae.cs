using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Carduelinae;

/// <summary>
/// Abstract class for Carduelinae (subfamily).
/// NCBI TaxId: 37599
/// </summary>
public abstract class Carduelinae : Fringillidae, ICarduelinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carduelinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "subfamily";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37599;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Carduelinae";
}
