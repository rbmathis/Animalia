using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Dendroperdix;

/// <summary>
/// Abstract class for Dendroperdix (genus).
/// NCBI TaxId: 388981
/// </summary>
public abstract class Dendroperdix : Phasianidae, IDendroperdix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendroperdix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 388981;

    /// <inheritdoc />
    public virtual string GenusName => "Dendroperdix";

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
