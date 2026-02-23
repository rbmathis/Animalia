using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Gyrinomimus;

/// <summary>
/// Abstract class for Gyrinomimus (genus).
/// NCBI TaxId: 88691
/// </summary>
public abstract class Gyrinomimus : Cetomimidae, IGyrinomimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gyrinomimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88691;

    /// <inheritdoc />
    public virtual string GenusName => "Gyrinomimus";

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
