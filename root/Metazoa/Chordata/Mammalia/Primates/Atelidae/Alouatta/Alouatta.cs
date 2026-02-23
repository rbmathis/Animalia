using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta;

/// <summary>
/// Abstract class for Alouatta (genus).
/// NCBI TaxId: 9499
/// </summary>
public abstract class Alouatta : Atelidae, IAlouatta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alouatta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9499;

    /// <inheritdoc />
    public virtual string GenusName => "Alouatta";

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
