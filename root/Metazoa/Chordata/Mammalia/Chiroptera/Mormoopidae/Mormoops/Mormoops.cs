using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mormoopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mormoopidae.Mormoops;

/// <summary>
/// Abstract class for Mormoops (genus).
/// NCBI TaxId: 59459
/// </summary>
public abstract class Mormoops : Mormoopidae, IMormoops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mormoops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59459;

    /// <inheritdoc />
    public virtual string GenusName => "Mormoops";

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
