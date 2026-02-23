using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Pseudalaemon;

/// <summary>
/// Abstract class for Pseudalaemon (genus).
/// NCBI TaxId: 1365203
/// </summary>
public abstract class Pseudalaemon : Alaudidae, IPseudalaemon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudalaemon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365203;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudalaemon";

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
