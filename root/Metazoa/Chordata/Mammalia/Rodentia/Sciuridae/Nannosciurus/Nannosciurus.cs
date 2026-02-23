using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Nannosciurus;

/// <summary>
/// Abstract class for Nannosciurus (genus).
/// NCBI TaxId: 226562
/// </summary>
public abstract class Nannosciurus : Sciuridae, INannosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226562;

    /// <inheritdoc />
    public virtual string GenusName => "Nannosciurus";

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
