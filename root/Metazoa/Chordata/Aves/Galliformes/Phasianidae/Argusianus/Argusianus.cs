using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Argusianus;

/// <summary>
/// Abstract class for Argusianus (genus).
/// NCBI TaxId: 9080
/// </summary>
public abstract class Argusianus : Phasianidae, IArgusianus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argusianus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9080;

    /// <inheritdoc />
    public virtual string GenusName => "Argusianus";

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
