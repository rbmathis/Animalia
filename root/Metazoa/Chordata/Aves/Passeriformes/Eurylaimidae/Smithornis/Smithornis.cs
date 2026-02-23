using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Smithornis;

/// <summary>
/// Abstract class for Smithornis (genus).
/// NCBI TaxId: 81929
/// </summary>
public abstract class Smithornis : Eurylaimidae, ISmithornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Smithornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81929;

    /// <inheritdoc />
    public virtual string GenusName => "Smithornis";

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
