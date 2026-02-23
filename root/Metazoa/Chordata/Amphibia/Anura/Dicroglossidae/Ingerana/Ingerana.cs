using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Ingerana;

/// <summary>
/// Abstract class for Ingerana (genus).
/// NCBI TaxId: 240401
/// </summary>
public abstract class Ingerana : Dicroglossidae, IIngerana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ingerana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240401;

    /// <inheritdoc />
    public virtual string GenusName => "Ingerana";

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
