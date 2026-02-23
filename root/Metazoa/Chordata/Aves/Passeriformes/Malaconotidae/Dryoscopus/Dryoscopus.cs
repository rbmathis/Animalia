using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae.Dryoscopus;

/// <summary>
/// Abstract class for Dryoscopus (genus).
/// NCBI TaxId: 85068
/// </summary>
public abstract class Dryoscopus : Malaconotidae, IDryoscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dryoscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85068;

    /// <inheritdoc />
    public virtual string GenusName => "Dryoscopus";

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
