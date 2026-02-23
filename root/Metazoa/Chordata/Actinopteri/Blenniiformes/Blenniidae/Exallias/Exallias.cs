using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Exallias;

/// <summary>
/// Abstract class for Exallias (genus).
/// NCBI TaxId: 1147084
/// </summary>
public abstract class Exallias : Blenniidae, IExallias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exallias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1147084;

    /// <inheritdoc />
    public virtual string GenusName => "Exallias";

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
