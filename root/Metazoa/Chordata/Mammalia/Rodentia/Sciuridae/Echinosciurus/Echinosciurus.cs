using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Echinosciurus;

/// <summary>
/// Abstract class for Echinosciurus (genus).
/// NCBI TaxId: 2895727
/// </summary>
public abstract class Echinosciurus : Sciuridae, IEchinosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echinosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2895727;

    /// <inheritdoc />
    public virtual string GenusName => "Echinosciurus";

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
