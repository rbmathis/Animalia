using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Spalax;

/// <summary>
/// Abstract class for Spalax (genus).
/// NCBI TaxId: 10062
/// </summary>
public abstract class Spalax : Spalacidae, ISpalax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spalax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10062;

    /// <inheritdoc />
    public virtual string GenusName => "Spalax";

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
