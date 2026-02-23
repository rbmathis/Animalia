using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Rheosaurus;

/// <summary>
/// Abstract class for Rheosaurus (genus).
/// NCBI TaxId: 2927777
/// </summary>
public abstract class Rheosaurus : Gymnophthalmidae, IRheosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rheosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2927777;

    /// <inheritdoc />
    public virtual string GenusName => "Rheosaurus";

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
