using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Pycnoptilus;

/// <summary>
/// Abstract class for Pycnoptilus (genus).
/// NCBI TaxId: 720587
/// </summary>
public abstract class Pycnoptilus : Acanthizidae, IPycnoptilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pycnoptilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 720587;

    /// <inheritdoc />
    public virtual string GenusName => "Pycnoptilus";

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
