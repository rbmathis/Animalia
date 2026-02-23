using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Euspondylus;

/// <summary>
/// Abstract class for Euspondylus (genus).
/// NCBI TaxId: 174748
/// </summary>
public abstract class Euspondylus : Gymnophthalmidae, IEuspondylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euspondylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174748;

    /// <inheritdoc />
    public virtual string GenusName => "Euspondylus";

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
