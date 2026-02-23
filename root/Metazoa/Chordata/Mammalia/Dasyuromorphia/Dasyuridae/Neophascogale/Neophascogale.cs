using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Neophascogale;

/// <summary>
/// Abstract class for Neophascogale (genus).
/// NCBI TaxId: 32550
/// </summary>
public abstract class Neophascogale : Dasyuridae, INeophascogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neophascogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32550;

    /// <inheritdoc />
    public virtual string GenusName => "Neophascogale";

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
