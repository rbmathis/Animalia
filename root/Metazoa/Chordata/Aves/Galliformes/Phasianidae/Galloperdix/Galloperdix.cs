using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Galloperdix;

/// <summary>
/// Abstract class for Galloperdix (genus).
/// NCBI TaxId: 466542
/// </summary>
public abstract class Galloperdix : Phasianidae, IGalloperdix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galloperdix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 466542;

    /// <inheritdoc />
    public virtual string GenusName => "Galloperdix";

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
