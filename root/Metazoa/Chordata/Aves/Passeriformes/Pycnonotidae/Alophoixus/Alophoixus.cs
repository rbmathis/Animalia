using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Alophoixus;

/// <summary>
/// Abstract class for Alophoixus (genus).
/// NCBI TaxId: 147056
/// </summary>
public abstract class Alophoixus : Pycnonotidae, IAlophoixus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alophoixus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 147056;

    /// <inheritdoc />
    public virtual string GenusName => "Alophoixus";

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
