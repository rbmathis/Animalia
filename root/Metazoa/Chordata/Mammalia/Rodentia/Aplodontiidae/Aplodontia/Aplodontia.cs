using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Aplodontiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Aplodontiidae.Aplodontia;

/// <summary>
/// Abstract class for Aplodontia (genus).
/// NCBI TaxId: 51341
/// </summary>
public abstract class Aplodontia : Aplodontiidae, IAplodontia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aplodontia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51341;

    /// <inheritdoc />
    public virtual string GenusName => "Aplodontia";

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
