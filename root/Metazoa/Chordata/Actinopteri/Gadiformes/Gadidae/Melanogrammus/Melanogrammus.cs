using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Melanogrammus;

/// <summary>
/// Abstract class for Melanogrammus (genus).
/// NCBI TaxId: 8055
/// </summary>
public abstract class Melanogrammus : Gadidae, IMelanogrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanogrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8055;

    /// <inheritdoc />
    public virtual string GenusName => "Melanogrammus";

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
