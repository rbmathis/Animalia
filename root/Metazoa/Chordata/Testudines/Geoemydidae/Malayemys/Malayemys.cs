using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Malayemys;

/// <summary>
/// Abstract class for Malayemys (genus).
/// NCBI TaxId: 74921
/// </summary>
public abstract class Malayemys : Geoemydidae, IMalayemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malayemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74921;

    /// <inheritdoc />
    public virtual string GenusName => "Malayemys";

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
