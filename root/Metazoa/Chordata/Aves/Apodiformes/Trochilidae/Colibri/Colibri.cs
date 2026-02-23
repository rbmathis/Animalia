using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Colibri;

/// <summary>
/// Abstract class for Colibri (genus).
/// NCBI TaxId: 214662
/// </summary>
public abstract class Colibri : Trochilidae, IColibri
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colibri";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 214662;

    /// <inheritdoc />
    public virtual string GenusName => "Colibri";

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
