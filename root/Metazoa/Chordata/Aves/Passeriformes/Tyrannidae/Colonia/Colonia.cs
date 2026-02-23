using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Colonia;

/// <summary>
/// Abstract class for Colonia (genus).
/// NCBI TaxId: 360211
/// </summary>
public abstract class Colonia : Tyrannidae, IColonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360211;

    /// <inheritdoc />
    public virtual string GenusName => "Colonia";

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
