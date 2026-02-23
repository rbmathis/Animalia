using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Nicator;

/// <summary>
/// Abstract class for Nicator (genus).
/// NCBI TaxId: 237431
/// </summary>
public abstract class Nicator : Pycnonotidae, INicator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nicator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 237431;

    /// <inheritdoc />
    public virtual string GenusName => "Nicator";

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
