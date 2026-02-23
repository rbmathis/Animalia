using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Lybius;

/// <summary>
/// Abstract class for Lybius (genus).
/// NCBI TaxId: 91769
/// </summary>
public abstract class Lybius : Lybiidae, ILybius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lybius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91769;

    /// <inheritdoc />
    public virtual string GenusName => "Lybius";

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
