using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Microdipodops;

/// <summary>
/// Abstract class for Microdipodops (genus).
/// NCBI TaxId: 108148
/// </summary>
public abstract class Microdipodops : Heteromyidae, IMicrodipodops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microdipodops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108148;

    /// <inheritdoc />
    public virtual string GenusName => "Microdipodops";

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
