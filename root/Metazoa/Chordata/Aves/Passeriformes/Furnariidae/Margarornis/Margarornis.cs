using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Margarornis;

/// <summary>
/// Abstract class for Margarornis (genus).
/// NCBI TaxId: 183166
/// </summary>
public abstract class Margarornis : Furnariidae, IMargarornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Margarornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183166;

    /// <inheritdoc />
    public virtual string GenusName => "Margarornis";

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
