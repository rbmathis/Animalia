using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Fluvicola;

/// <summary>
/// Abstract class for Fluvicola (genus).
/// NCBI TaxId: 196029
/// </summary>
public abstract class Fluvicola : Tyrannidae, IFluvicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fluvicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196029;

    /// <inheritdoc />
    public virtual string GenusName => "Fluvicola";

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
