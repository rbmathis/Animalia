using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Bryconella;

/// <summary>
/// Abstract class for Bryconella (genus).
/// NCBI TaxId: 930304
/// </summary>
public abstract class Bryconella : Acestrorhamphidae, IBryconella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryconella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930304;

    /// <inheritdoc />
    public virtual string GenusName => "Bryconella";

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
