using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Phasianus;

/// <summary>
/// Abstract class for Phasianus (genus).
/// NCBI TaxId: 9053
/// </summary>
public abstract class Phasianus : Phasianidae, IPhasianus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phasianus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9053;

    /// <inheritdoc />
    public virtual string GenusName => "Phasianus";

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
