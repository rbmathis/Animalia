using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Hippolais;

/// <summary>
/// Abstract class for Hippolais (genus).
/// NCBI TaxId: 68489
/// </summary>
public abstract class Hippolais : Sylviidae, IHippolais
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hippolais";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68489;

    /// <inheritdoc />
    public virtual string GenusName => "Hippolais";

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
