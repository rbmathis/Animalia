using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Alaemon;

/// <summary>
/// Abstract class for Alaemon (genus).
/// NCBI TaxId: 215279
/// </summary>
public abstract class Alaemon : Alaudidae, IAlaemon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alaemon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215279;

    /// <inheritdoc />
    public virtual string GenusName => "Alaemon";

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
