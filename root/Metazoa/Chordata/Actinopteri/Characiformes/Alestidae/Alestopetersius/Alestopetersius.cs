using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Alestopetersius;

/// <summary>
/// Abstract class for Alestopetersius (genus).
/// NCBI TaxId: 304010
/// </summary>
public abstract class Alestopetersius : Alestidae, IAlestopetersius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alestopetersius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304010;

    /// <inheritdoc />
    public virtual string GenusName => "Alestopetersius";

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
