using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Sandelia;

/// <summary>
/// Abstract class for Sandelia (genus).
/// NCBI TaxId: 313172
/// </summary>
public abstract class Sandelia : Anabantidae, ISandelia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sandelia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 313172;

    /// <inheritdoc />
    public virtual string GenusName => "Sandelia";

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
