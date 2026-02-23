using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Brachypodius;

/// <summary>
/// Abstract class for Brachypodius (genus).
/// NCBI TaxId: 1766907
/// </summary>
public abstract class Brachypodius : Pycnonotidae, IBrachypodius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachypodius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1766907;

    /// <inheritdoc />
    public virtual string GenusName => "Brachypodius";

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
