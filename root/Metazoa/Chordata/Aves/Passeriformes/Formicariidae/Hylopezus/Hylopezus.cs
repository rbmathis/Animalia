using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Hylopezus;

/// <summary>
/// Abstract class for Hylopezus (genus).
/// NCBI TaxId: 117177
/// </summary>
public abstract class Hylopezus : Formicariidae, IHylopezus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylopezus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117177;

    /// <inheritdoc />
    public virtual string GenusName => "Hylopezus";

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
