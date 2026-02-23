using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Baeopogon;

/// <summary>
/// Abstract class for Baeopogon (genus).
/// NCBI TaxId: 182903
/// </summary>
public abstract class Baeopogon : Pycnonotidae, IBaeopogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Baeopogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182903;

    /// <inheritdoc />
    public virtual string GenusName => "Baeopogon";

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
