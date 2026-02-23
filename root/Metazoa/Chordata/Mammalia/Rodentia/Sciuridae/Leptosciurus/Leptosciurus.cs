using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Leptosciurus;

/// <summary>
/// Abstract class for Leptosciurus (genus).
/// NCBI TaxId: 2895728
/// </summary>
public abstract class Leptosciurus : Sciuridae, ILeptosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2895728;

    /// <inheritdoc />
    public virtual string GenusName => "Leptosciurus";

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
