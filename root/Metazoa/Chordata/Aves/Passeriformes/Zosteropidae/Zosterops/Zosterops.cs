using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Zosterops;

/// <summary>
/// Abstract class for Zosterops (genus).
/// NCBI TaxId: 36298
/// </summary>
public abstract class Zosterops : Zosteropidae, IZosterops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zosterops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36298;

    /// <inheritdoc />
    public virtual string GenusName => "Zosterops";

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
