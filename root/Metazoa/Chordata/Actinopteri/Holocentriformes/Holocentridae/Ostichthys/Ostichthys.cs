using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Ostichthys;

/// <summary>
/// Abstract class for Ostichthys (genus).
/// NCBI TaxId: 181436
/// </summary>
public abstract class Ostichthys : Holocentridae, IOstichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ostichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181436;

    /// <inheritdoc />
    public virtual string GenusName => "Ostichthys";

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
