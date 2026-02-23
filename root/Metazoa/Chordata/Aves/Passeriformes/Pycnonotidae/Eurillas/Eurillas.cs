using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Eurillas;

/// <summary>
/// Abstract class for Eurillas (genus).
/// NCBI TaxId: 1743265
/// </summary>
public abstract class Eurillas : Pycnonotidae, IEurillas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurillas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1743265;

    /// <inheritdoc />
    public virtual string GenusName => "Eurillas";

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
