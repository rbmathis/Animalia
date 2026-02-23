using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Pronotogrammus;

/// <summary>
/// Abstract class for Pronotogrammus (genus).
/// NCBI TaxId: 160739
/// </summary>
public abstract class Pronotogrammus : Anthiadidae, IPronotogrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pronotogrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160739;

    /// <inheritdoc />
    public virtual string GenusName => "Pronotogrammus";

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
