using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Agriornis;

/// <summary>
/// Abstract class for Agriornis (genus).
/// NCBI TaxId: 123639
/// </summary>
public abstract class Agriornis : Tyrannidae, IAgriornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agriornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123639;

    /// <inheritdoc />
    public virtual string GenusName => "Agriornis";

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
