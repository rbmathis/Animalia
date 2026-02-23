using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Criniger;

/// <summary>
/// Abstract class for Criniger (genus).
/// NCBI TaxId: 182878
/// </summary>
public abstract class Criniger : Pycnonotidae, ICriniger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Criniger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182878;

    /// <inheritdoc />
    public virtual string GenusName => "Criniger";

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
