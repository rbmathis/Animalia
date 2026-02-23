using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Grallenia;

/// <summary>
/// Abstract class for Grallenia (genus).
/// NCBI TaxId: 2845812
/// </summary>
public abstract class Grallenia : Gobiidae, IGrallenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grallenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2845812;

    /// <inheritdoc />
    public virtual string GenusName => "Grallenia";

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
