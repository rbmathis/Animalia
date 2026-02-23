using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Brachylophus;

/// <summary>
/// Abstract class for Brachylophus (genus).
/// NCBI TaxId: 46194
/// </summary>
public abstract class Brachylophus : Iguanidae, IBrachylophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachylophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46194;

    /// <inheritdoc />
    public virtual string GenusName => "Brachylophus";

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
