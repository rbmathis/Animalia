using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Homalopterula;

/// <summary>
/// Abstract class for Homalopterula (genus).
/// NCBI TaxId: 1590167
/// </summary>
public abstract class Homalopterula : Balitoridae, IHomalopterula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homalopterula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1590167;

    /// <inheritdoc />
    public virtual string GenusName => "Homalopterula";

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
