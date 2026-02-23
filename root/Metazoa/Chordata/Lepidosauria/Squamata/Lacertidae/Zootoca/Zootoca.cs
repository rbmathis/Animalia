using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Zootoca;

/// <summary>
/// Abstract class for Zootoca (genus).
/// NCBI TaxId: 141678
/// </summary>
public abstract class Zootoca : Lacertidae, IZootoca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zootoca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 141678;

    /// <inheritdoc />
    public virtual string GenusName => "Zootoca";

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
