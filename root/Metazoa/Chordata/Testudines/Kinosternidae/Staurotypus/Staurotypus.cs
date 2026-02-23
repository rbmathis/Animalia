using AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Staurotypus;

/// <summary>
/// Abstract class for Staurotypus (genus).
/// NCBI TaxId: 55536
/// </summary>
public abstract class Staurotypus : Kinosternidae, IStaurotypus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Staurotypus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55536;

    /// <inheritdoc />
    public virtual string GenusName => "Staurotypus";

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
