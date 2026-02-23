using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Betadevario;

/// <summary>
/// Abstract class for Betadevario (genus).
/// NCBI TaxId: 794812
/// </summary>
public abstract class Betadevario : Danionidae, IBetadevario
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Betadevario";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 794812;

    /// <inheritdoc />
    public virtual string GenusName => "Betadevario";

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
