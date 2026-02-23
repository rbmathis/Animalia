using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Amapasaurus;

/// <summary>
/// Abstract class for Amapasaurus (genus).
/// NCBI TaxId: 1539291
/// </summary>
public abstract class Amapasaurus : Gymnophthalmidae, IAmapasaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amapasaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1539291;

    /// <inheritdoc />
    public virtual string GenusName => "Amapasaurus";

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
