using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Stelgidillas;

/// <summary>
/// Abstract class for Stelgidillas (genus).
/// NCBI TaxId: 1743381
/// </summary>
public abstract class Stelgidillas : Pycnonotidae, IStelgidillas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stelgidillas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1743381;

    /// <inheritdoc />
    public virtual string GenusName => "Stelgidillas";

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
