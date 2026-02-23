using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Ozimops;

/// <summary>
/// Abstract class for Ozimops (genus).
/// NCBI TaxId: 2689069
/// </summary>
public abstract class Ozimops : Molossidae, IOzimops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ozimops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2689069;

    /// <inheritdoc />
    public virtual string GenusName => "Ozimops";

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
