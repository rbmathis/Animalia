using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Inimicus;

/// <summary>
/// Abstract class for Inimicus (genus).
/// NCBI TaxId: 390342
/// </summary>
public abstract class Inimicus : Synanceiidae, IInimicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Inimicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390342;

    /// <inheritdoc />
    public virtual string GenusName => "Inimicus";

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
