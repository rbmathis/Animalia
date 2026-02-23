using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Scriptosaura;

/// <summary>
/// Abstract class for Scriptosaura (genus).
/// NCBI TaxId: 1545801
/// </summary>
public abstract class Scriptosaura : Gymnophthalmidae, IScriptosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scriptosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545801;

    /// <inheritdoc />
    public virtual string GenusName => "Scriptosaura";

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
