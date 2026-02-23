using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Guerlinguetus;

/// <summary>
/// Abstract class for Guerlinguetus (genus).
/// NCBI TaxId: 2749090
/// </summary>
public abstract class Guerlinguetus : Sciuridae, IGuerlinguetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guerlinguetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2749090;

    /// <inheritdoc />
    public virtual string GenusName => "Guerlinguetus";

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
