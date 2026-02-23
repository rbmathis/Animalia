using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Neophrynichthys;

/// <summary>
/// Abstract class for Neophrynichthys (genus).
/// NCBI TaxId: 2696667
/// </summary>
public abstract class Neophrynichthys : Psychrolutidae, INeophrynichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neophrynichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696667;

    /// <inheritdoc />
    public virtual string GenusName => "Neophrynichthys";

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
