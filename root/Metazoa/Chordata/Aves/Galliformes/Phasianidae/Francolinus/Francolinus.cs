using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Francolinus;

/// <summary>
/// Abstract class for Francolinus (genus).
/// NCBI TaxId: 9018
/// </summary>
public abstract class Francolinus : Phasianidae, IFrancolinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Francolinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9018;

    /// <inheritdoc />
    public virtual string GenusName => "Francolinus";

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
