using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Limnornis;

/// <summary>
/// Abstract class for Limnornis (genus).
/// NCBI TaxId: 329486
/// </summary>
public abstract class Limnornis : Furnariidae, ILimnornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329486;

    /// <inheritdoc />
    public virtual string GenusName => "Limnornis";

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
