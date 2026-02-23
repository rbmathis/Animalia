using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Limnonectes;

/// <summary>
/// Abstract class for Limnonectes (genus).
/// NCBI TaxId: 109961
/// </summary>
public abstract class Limnonectes : Dicroglossidae, ILimnonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109961;

    /// <inheritdoc />
    public virtual string GenusName => "Limnonectes";

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
