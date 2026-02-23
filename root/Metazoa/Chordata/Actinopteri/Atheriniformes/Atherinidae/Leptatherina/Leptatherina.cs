using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Leptatherina;

/// <summary>
/// Abstract class for Leptatherina (genus).
/// NCBI TaxId: 154829
/// </summary>
public abstract class Leptatherina : Atherinidae, ILeptatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 154829;

    /// <inheritdoc />
    public virtual string GenusName => "Leptatherina";

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
