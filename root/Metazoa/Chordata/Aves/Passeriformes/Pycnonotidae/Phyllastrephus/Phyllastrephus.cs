using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Phyllastrephus;

/// <summary>
/// Abstract class for Phyllastrephus (genus).
/// NCBI TaxId: 59967
/// </summary>
public abstract class Phyllastrephus : Pycnonotidae, IPhyllastrephus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllastrephus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59967;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllastrephus";

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
