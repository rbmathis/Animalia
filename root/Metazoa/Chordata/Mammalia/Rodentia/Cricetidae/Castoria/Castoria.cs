using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Castoria;

/// <summary>
/// Abstract class for Castoria (genus).
/// NCBI TaxId: 2302992
/// </summary>
public abstract class Castoria : Cricetidae, ICastoria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Castoria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2302992;

    /// <inheritdoc />
    public virtual string GenusName => "Castoria";

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
