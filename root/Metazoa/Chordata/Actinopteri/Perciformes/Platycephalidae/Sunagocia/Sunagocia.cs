using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Sunagocia;

/// <summary>
/// Abstract class for Sunagocia (genus).
/// NCBI TaxId: 1230801
/// </summary>
public abstract class Sunagocia : Platycephalidae, ISunagocia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sunagocia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1230801;

    /// <inheritdoc />
    public virtual string GenusName => "Sunagocia";

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
