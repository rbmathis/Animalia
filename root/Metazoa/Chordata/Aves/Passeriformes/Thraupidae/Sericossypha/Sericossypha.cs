using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Sericossypha;

/// <summary>
/// Abstract class for Sericossypha (genus).
/// NCBI TaxId: 62244
/// </summary>
public abstract class Sericossypha : Thraupidae, ISericossypha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sericossypha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62244;

    /// <inheritdoc />
    public virtual string GenusName => "Sericossypha";

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
