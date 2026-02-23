using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Bleda;

/// <summary>
/// Abstract class for Bleda (genus).
/// NCBI TaxId: 182876
/// </summary>
public abstract class Bleda : Pycnonotidae, IBleda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bleda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182876;

    /// <inheritdoc />
    public virtual string GenusName => "Bleda";

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
