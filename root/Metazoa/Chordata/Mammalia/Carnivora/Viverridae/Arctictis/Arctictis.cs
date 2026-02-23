using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Arctictis;

/// <summary>
/// Abstract class for Arctictis (genus).
/// NCBI TaxId: 94179
/// </summary>
public abstract class Arctictis : Viverridae, IArctictis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arctictis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94179;

    /// <inheritdoc />
    public virtual string GenusName => "Arctictis";

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
