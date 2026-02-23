using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lophura;

/// <summary>
/// Abstract class for Lophura (genus).
/// NCBI TaxId: 9041
/// </summary>
public abstract class Lophura : Phasianidae, ILophura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9041;

    /// <inheritdoc />
    public virtual string GenusName => "Lophura";

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
