using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Chaetodipus;

/// <summary>
/// Abstract class for Chaetodipus (genus).
/// NCBI TaxId: 38664
/// </summary>
public abstract class Chaetodipus : Heteromyidae, IChaetodipus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetodipus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38664;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetodipus";

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
