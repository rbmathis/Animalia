using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Acestrorhamphidae_polyphyletic_genera;

/// <summary>
/// Abstract class for Acestrorhamphidae polyphyletic genera (no rank).
/// NCBI TaxId: 3391773
/// </summary>
public abstract class Acestrorhamphidae_polyphyletic_genera : Acestrorhamphidae, IAcestrorhamphidae_polyphyletic_genera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acestrorhamphidae polyphyletic genera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3391773;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Acestrorhamphidae_polyphyletic_genera";
}
