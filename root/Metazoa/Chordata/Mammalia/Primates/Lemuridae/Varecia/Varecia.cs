using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Varecia;

/// <summary>
/// Abstract class for Varecia (genus).
/// NCBI TaxId: 9454
/// </summary>
public abstract class Varecia : Lemuridae, IVarecia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Varecia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9454;

    /// <inheritdoc />
    public virtual string GenusName => "Varecia";

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
