using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Falcipennis;

/// <summary>
/// Abstract class for Falcipennis (genus).
/// NCBI TaxId: 109673
/// </summary>
public abstract class Falcipennis : Phasianidae, IFalcipennis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Falcipennis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109673;

    /// <inheritdoc />
    public virtual string GenusName => "Falcipennis";

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
