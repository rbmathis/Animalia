using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Saccopharyngidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Saccopharyngidae.Saccopharynx;

/// <summary>
/// Abstract class for Saccopharynx (genus).
/// NCBI TaxId: 136489
/// </summary>
public abstract class Saccopharynx : Saccopharyngidae, ISaccopharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saccopharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 136489;

    /// <inheritdoc />
    public virtual string GenusName => "Saccopharynx";

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
