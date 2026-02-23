using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Bhavania;

/// <summary>
/// Abstract class for Bhavania (genus).
/// NCBI TaxId: 1396450
/// </summary>
public abstract class Bhavania : Balitoridae, IBhavania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bhavania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1396450;

    /// <inheritdoc />
    public virtual string GenusName => "Bhavania";

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
