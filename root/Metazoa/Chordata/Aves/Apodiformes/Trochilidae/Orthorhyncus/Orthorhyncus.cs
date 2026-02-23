using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Orthorhyncus;

/// <summary>
/// Abstract class for Orthorhyncus (genus).
/// NCBI TaxId: 111987
/// </summary>
public abstract class Orthorhyncus : Trochilidae, IOrthorhyncus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthorhyncus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111987;

    /// <inheritdoc />
    public virtual string GenusName => "Orthorhyncus";

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
