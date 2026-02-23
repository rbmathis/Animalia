using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Nanorana;

/// <summary>
/// Abstract class for Nanorana (genus).
/// NCBI TaxId: 120497
/// </summary>
public abstract class Nanorana : Dicroglossidae, INanorana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nanorana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 120497;

    /// <inheritdoc />
    public virtual string GenusName => "Nanorana";

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
