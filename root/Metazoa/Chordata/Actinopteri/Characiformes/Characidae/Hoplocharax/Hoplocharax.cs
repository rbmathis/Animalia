using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Hoplocharax;

/// <summary>
/// Abstract class for Hoplocharax (genus).
/// NCBI TaxId: 930340
/// </summary>
public abstract class Hoplocharax : Characidae, IHoplocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930340;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplocharax";

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
