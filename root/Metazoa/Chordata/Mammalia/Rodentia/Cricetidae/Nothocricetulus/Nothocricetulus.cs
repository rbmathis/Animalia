using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nothocricetulus;

/// <summary>
/// Abstract class for Nothocricetulus (genus).
/// NCBI TaxId: 3122391
/// </summary>
public abstract class Nothocricetulus : Cricetidae, INothocricetulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nothocricetulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3122391;

    /// <inheritdoc />
    public virtual string GenusName => "Nothocricetulus";

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
