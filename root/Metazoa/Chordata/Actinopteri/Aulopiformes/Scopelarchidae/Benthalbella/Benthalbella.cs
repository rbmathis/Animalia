using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Benthalbella;

/// <summary>
/// Abstract class for Benthalbella (genus).
/// NCBI TaxId: 433384
/// </summary>
public abstract class Benthalbella : Scopelarchidae, IBenthalbella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Benthalbella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 433384;

    /// <inheritdoc />
    public virtual string GenusName => "Benthalbella";

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
