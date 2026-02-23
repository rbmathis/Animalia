using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Brycinus;

/// <summary>
/// Abstract class for Brycinus (genus).
/// NCBI TaxId: 206420
/// </summary>
public abstract class Brycinus : Alestidae, IBrycinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brycinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206420;

    /// <inheritdoc />
    public virtual string GenusName => "Brycinus";

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
