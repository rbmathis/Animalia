using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Quasipaa;

/// <summary>
/// Abstract class for Quasipaa (genus).
/// NCBI TaxId: 862141
/// </summary>
public abstract class Quasipaa : Dicroglossidae, IQuasipaa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Quasipaa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862141;

    /// <inheritdoc />
    public virtual string GenusName => "Quasipaa";

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
