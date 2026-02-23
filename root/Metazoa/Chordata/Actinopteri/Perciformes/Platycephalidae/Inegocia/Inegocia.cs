using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Inegocia;

/// <summary>
/// Abstract class for Inegocia (genus).
/// NCBI TaxId: 1043195
/// </summary>
public abstract class Inegocia : Platycephalidae, IInegocia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Inegocia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1043195;

    /// <inheritdoc />
    public virtual string GenusName => "Inegocia";

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
