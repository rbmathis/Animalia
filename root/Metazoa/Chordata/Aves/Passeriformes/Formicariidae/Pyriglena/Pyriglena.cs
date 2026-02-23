using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Pyriglena;

/// <summary>
/// Abstract class for Pyriglena (genus).
/// NCBI TaxId: 183186
/// </summary>
public abstract class Pyriglena : Formicariidae, IPyriglena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyriglena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183186;

    /// <inheritdoc />
    public virtual string GenusName => "Pyriglena";

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
