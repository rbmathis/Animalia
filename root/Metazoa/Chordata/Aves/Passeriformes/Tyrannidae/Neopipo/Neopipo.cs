using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Neopipo;

/// <summary>
/// Abstract class for Neopipo (genus).
/// NCBI TaxId: 456387
/// </summary>
public abstract class Neopipo : Tyrannidae, INeopipo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neopipo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 456387;

    /// <inheritdoc />
    public virtual string GenusName => "Neopipo";

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
