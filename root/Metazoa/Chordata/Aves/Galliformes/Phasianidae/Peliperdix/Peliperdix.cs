using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Peliperdix;

/// <summary>
/// Abstract class for Peliperdix (genus).
/// NCBI TaxId: 388983
/// </summary>
public abstract class Peliperdix : Phasianidae, IPeliperdix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peliperdix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 388983;

    /// <inheritdoc />
    public virtual string GenusName => "Peliperdix";

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
