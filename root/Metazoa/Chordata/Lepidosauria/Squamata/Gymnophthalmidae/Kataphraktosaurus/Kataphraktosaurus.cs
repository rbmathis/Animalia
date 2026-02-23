using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Kataphraktosaurus;

/// <summary>
/// Abstract class for Kataphraktosaurus (genus).
/// NCBI TaxId: 2832003
/// </summary>
public abstract class Kataphraktosaurus : Gymnophthalmidae, IKataphraktosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kataphraktosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2832003;

    /// <inheritdoc />
    public virtual string GenusName => "Kataphraktosaurus";

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
