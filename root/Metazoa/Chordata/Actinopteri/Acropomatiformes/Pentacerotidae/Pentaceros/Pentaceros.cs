using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Pentaceros;

/// <summary>
/// Abstract class for Pentaceros (genus).
/// NCBI TaxId: 257888
/// </summary>
public abstract class Pentaceros : Pentacerotidae, IPentaceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pentaceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 257888;

    /// <inheritdoc />
    public virtual string GenusName => "Pentaceros";

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
