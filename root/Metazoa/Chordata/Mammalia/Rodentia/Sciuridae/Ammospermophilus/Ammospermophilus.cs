using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Ammospermophilus;

/// <summary>
/// Abstract class for Ammospermophilus (genus).
/// NCBI TaxId: 45485
/// </summary>
public abstract class Ammospermophilus : Sciuridae, IAmmospermophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammospermophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45485;

    /// <inheritdoc />
    public virtual string GenusName => "Ammospermophilus";

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
