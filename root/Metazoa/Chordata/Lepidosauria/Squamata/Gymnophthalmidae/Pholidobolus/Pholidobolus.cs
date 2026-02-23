using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Pholidobolus;

/// <summary>
/// Abstract class for Pholidobolus (genus).
/// NCBI TaxId: 171159
/// </summary>
public abstract class Pholidobolus : Gymnophthalmidae, IPholidobolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pholidobolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171159;

    /// <inheritdoc />
    public virtual string GenusName => "Pholidobolus";

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
