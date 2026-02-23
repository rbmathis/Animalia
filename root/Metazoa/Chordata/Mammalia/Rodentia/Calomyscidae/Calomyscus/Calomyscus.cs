using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Calomyscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Calomyscidae.Calomyscus;

/// <summary>
/// Abstract class for Calomyscus (genus).
/// NCBI TaxId: 10132
/// </summary>
public abstract class Calomyscus : Calomyscidae, ICalomyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calomyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10132;

    /// <inheritdoc />
    public virtual string GenusName => "Calomyscus";

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
