using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Cetorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Cetorhinidae.Cetorhinus;

/// <summary>
/// Abstract class for Cetorhinus (genus).
/// NCBI TaxId: 57981
/// </summary>
public abstract class Cetorhinus : Cetorhinidae, ICetorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cetorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57981;

    /// <inheritdoc />
    public virtual string GenusName => "Cetorhinus";

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
