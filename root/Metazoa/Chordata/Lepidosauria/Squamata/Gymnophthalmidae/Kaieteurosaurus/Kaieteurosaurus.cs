using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Kaieteurosaurus;

/// <summary>
/// Abstract class for Kaieteurosaurus (genus).
/// NCBI TaxId: 1221497
/// </summary>
public abstract class Kaieteurosaurus : Gymnophthalmidae, IKaieteurosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kaieteurosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1221497;

    /// <inheritdoc />
    public virtual string GenusName => "Kaieteurosaurus";

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
