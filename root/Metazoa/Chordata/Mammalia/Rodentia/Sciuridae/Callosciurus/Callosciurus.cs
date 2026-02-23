using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Callosciurus;

/// <summary>
/// Abstract class for Callosciurus (genus).
/// NCBI TaxId: 64663
/// </summary>
public abstract class Callosciurus : Sciuridae, ICallosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64663;

    /// <inheritdoc />
    public virtual string GenusName => "Callosciurus";

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
