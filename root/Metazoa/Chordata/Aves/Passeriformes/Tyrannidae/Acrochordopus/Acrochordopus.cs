using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Acrochordopus;

/// <summary>
/// Abstract class for Acrochordopus (genus).
/// NCBI TaxId: 3388944
/// </summary>
public abstract class Acrochordopus : Tyrannidae, IAcrochordopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acrochordopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3388944;

    /// <inheritdoc />
    public virtual string GenusName => "Acrochordopus";

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
