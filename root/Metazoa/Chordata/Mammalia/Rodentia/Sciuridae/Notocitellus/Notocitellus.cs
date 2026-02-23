using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Notocitellus;

/// <summary>
/// Abstract class for Notocitellus (genus).
/// NCBI TaxId: 1141636
/// </summary>
public abstract class Notocitellus : Sciuridae, INotocitellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notocitellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1141636;

    /// <inheritdoc />
    public virtual string GenusName => "Notocitellus";

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
