using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Trogloglanis;

/// <summary>
/// Abstract class for Trogloglanis (genus).
/// NCBI TaxId: 2708358
/// </summary>
public abstract class Trogloglanis : Ictaluridae, ITrogloglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trogloglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2708358;

    /// <inheritdoc />
    public virtual string GenusName => "Trogloglanis";

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
