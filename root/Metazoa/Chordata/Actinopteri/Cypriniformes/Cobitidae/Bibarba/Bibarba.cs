using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Bibarba;

/// <summary>
/// Abstract class for Bibarba (genus).
/// NCBI TaxId: 1868606
/// </summary>
public abstract class Bibarba : Cobitidae, IBibarba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bibarba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1868606;

    /// <inheritdoc />
    public virtual string GenusName => "Bibarba";

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
