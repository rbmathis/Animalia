using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Acinonyx;

/// <summary>
/// Abstract class for Acinonyx (genus).
/// NCBI TaxId: 32535
/// </summary>
public abstract class Acinonyx : Felidae, IAcinonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acinonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32535;

    /// <inheritdoc />
    public virtual string GenusName => "Acinonyx";

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
