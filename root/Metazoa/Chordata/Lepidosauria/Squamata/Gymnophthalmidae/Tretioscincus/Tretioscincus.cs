using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Tretioscincus;

/// <summary>
/// Abstract class for Tretioscincus (genus).
/// NCBI TaxId: 88859
/// </summary>
public abstract class Tretioscincus : Gymnophthalmidae, ITretioscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tretioscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88859;

    /// <inheritdoc />
    public virtual string GenusName => "Tretioscincus";

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
