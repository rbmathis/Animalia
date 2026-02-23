using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Pogoniulus;

/// <summary>
/// Abstract class for Pogoniulus (genus).
/// NCBI TaxId: 91774
/// </summary>
public abstract class Pogoniulus : Lybiidae, IPogoniulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pogoniulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91774;

    /// <inheritdoc />
    public virtual string GenusName => "Pogoniulus";

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
