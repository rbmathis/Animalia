using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Emarginata;

/// <summary>
/// Abstract class for Emarginata (genus).
/// NCBI TaxId: 3150805
/// </summary>
public abstract class Emarginata : Muscicapidae, IEmarginata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emarginata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150805;

    /// <inheritdoc />
    public virtual string GenusName => "Emarginata";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
