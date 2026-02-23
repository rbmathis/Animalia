using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Archolaemus;

/// <summary>
/// Abstract class for Archolaemus (genus).
/// NCBI TaxId: 77844
/// </summary>
public abstract class Archolaemus : Sternopygidae, IArcholaemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archolaemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77844;

    /// <inheritdoc />
    public virtual string GenusName => "Archolaemus";

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
