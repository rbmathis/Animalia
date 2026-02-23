using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Hylonympha;

/// <summary>
/// Abstract class for Hylonympha (genus).
/// NCBI TaxId: 335809
/// </summary>
public abstract class Hylonympha : Trochilidae, IHylonympha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylonympha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 335809;

    /// <inheritdoc />
    public virtual string GenusName => "Hylonympha";

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
