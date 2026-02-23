using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Thyrsites;

/// <summary>
/// Abstract class for Thyrsites (genus).
/// NCBI TaxId: 499857
/// </summary>
public abstract class Thyrsites : Gempylidae, IThyrsites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thyrsites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 499857;

    /// <inheritdoc />
    public virtual string GenusName => "Thyrsites";

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
