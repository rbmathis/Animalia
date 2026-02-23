using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Pucrasia;

/// <summary>
/// Abstract class for Pucrasia (genus).
/// NCBI TaxId: 9060
/// </summary>
public abstract class Pucrasia : Phasianidae, IPucrasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pucrasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9060;

    /// <inheritdoc />
    public virtual string GenusName => "Pucrasia";

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
