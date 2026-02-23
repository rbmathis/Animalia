using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Rollulus;

/// <summary>
/// Abstract class for Rollulus (genus).
/// NCBI TaxId: 30404
/// </summary>
public abstract class Rollulus : Phasianidae, IRollulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rollulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30404;

    /// <inheritdoc />
    public virtual string GenusName => "Rollulus";

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
