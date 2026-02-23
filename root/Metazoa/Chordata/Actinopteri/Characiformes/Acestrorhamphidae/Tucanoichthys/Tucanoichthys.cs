using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Tucanoichthys;

/// <summary>
/// Abstract class for Tucanoichthys (genus).
/// NCBI TaxId: 1739084
/// </summary>
public abstract class Tucanoichthys : Acestrorhamphidae, ITucanoichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tucanoichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1739084;

    /// <inheritdoc />
    public virtual string GenusName => "Tucanoichthys";

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
