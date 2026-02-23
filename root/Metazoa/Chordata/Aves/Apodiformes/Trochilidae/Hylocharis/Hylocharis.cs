using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Hylocharis;

/// <summary>
/// Abstract class for Hylocharis (genus).
/// NCBI TaxId: 135174
/// </summary>
public abstract class Hylocharis : Trochilidae, IHylocharis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylocharis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135174;

    /// <inheritdoc />
    public virtual string GenusName => "Hylocharis";

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
