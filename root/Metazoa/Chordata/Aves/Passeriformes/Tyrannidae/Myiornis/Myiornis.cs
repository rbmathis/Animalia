using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiornis;

/// <summary>
/// Abstract class for Myiornis (genus).
/// NCBI TaxId: 360215
/// </summary>
public abstract class Myiornis : Tyrannidae, IMyiornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360215;

    /// <inheritdoc />
    public virtual string GenusName => "Myiornis";

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
