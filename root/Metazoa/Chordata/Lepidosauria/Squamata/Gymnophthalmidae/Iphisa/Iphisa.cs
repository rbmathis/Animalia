using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Iphisa;

/// <summary>
/// Abstract class for Iphisa (genus).
/// NCBI TaxId: 88862
/// </summary>
public abstract class Iphisa : Gymnophthalmidae, IIphisa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iphisa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88862;

    /// <inheritdoc />
    public virtual string GenusName => "Iphisa";

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
