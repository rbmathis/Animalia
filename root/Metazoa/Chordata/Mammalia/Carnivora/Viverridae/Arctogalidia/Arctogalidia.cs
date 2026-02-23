using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Arctogalidia;

/// <summary>
/// Abstract class for Arctogalidia (genus).
/// NCBI TaxId: 94181
/// </summary>
public abstract class Arctogalidia : Viverridae, IArctogalidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arctogalidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94181;

    /// <inheritdoc />
    public virtual string GenusName => "Arctogalidia";

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
