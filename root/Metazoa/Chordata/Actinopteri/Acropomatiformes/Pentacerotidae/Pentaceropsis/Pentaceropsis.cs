using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Pentaceropsis;

/// <summary>
/// Abstract class for Pentaceropsis (genus).
/// NCBI TaxId: 334888
/// </summary>
public abstract class Pentaceropsis : Pentacerotidae, IPentaceropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pentaceropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334888;

    /// <inheritdoc />
    public virtual string GenusName => "Pentaceropsis";

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
