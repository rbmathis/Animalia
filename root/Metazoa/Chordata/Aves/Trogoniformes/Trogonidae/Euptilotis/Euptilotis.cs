using AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Euptilotis;

/// <summary>
/// Abstract class for Euptilotis (genus).
/// NCBI TaxId: 57414
/// </summary>
public abstract class Euptilotis : Trogonidae, IEuptilotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euptilotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57414;

    /// <inheritdoc />
    public virtual string GenusName => "Euptilotis";

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
