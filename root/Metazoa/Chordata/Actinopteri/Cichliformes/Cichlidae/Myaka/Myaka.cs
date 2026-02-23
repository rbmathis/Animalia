using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Myaka;

/// <summary>
/// Abstract class for Myaka (genus).
/// NCBI TaxId: 296565
/// </summary>
public abstract class Myaka : Cichlidae, IMyaka
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myaka";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 296565;

    /// <inheritdoc />
    public virtual string GenusName => "Myaka";

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
