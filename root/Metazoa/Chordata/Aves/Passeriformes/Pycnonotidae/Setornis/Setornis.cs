using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Setornis;

/// <summary>
/// Abstract class for Setornis (genus).
/// NCBI TaxId: 374641
/// </summary>
public abstract class Setornis : Pycnonotidae, ISetornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Setornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374641;

    /// <inheritdoc />
    public virtual string GenusName => "Setornis";

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
