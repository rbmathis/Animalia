using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Opsarius;

/// <summary>
/// Abstract class for Opsarius (genus).
/// NCBI TaxId: 857701
/// </summary>
public abstract class Opsarius : Danionidae, IOpsarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opsarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 857701;

    /// <inheritdoc />
    public virtual string GenusName => "Opsarius";

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
