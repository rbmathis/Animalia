using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Poliocitellus;

/// <summary>
/// Abstract class for Poliocitellus (genus).
/// NCBI TaxId: 1141641
/// </summary>
public abstract class Poliocitellus : Sciuridae, IPoliocitellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poliocitellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1141641;

    /// <inheritdoc />
    public virtual string GenusName => "Poliocitellus";

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
