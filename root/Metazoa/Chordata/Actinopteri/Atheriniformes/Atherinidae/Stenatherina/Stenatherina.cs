using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Stenatherina;

/// <summary>
/// Abstract class for Stenatherina (genus).
/// NCBI TaxId: 1395012
/// </summary>
public abstract class Stenatherina : Atherinidae, IStenatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stenatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1395012;

    /// <inheritdoc />
    public virtual string GenusName => "Stenatherina";

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
