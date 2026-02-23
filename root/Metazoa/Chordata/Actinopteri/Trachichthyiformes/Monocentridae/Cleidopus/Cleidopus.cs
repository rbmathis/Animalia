using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Monocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Monocentridae.Cleidopus;

/// <summary>
/// Abstract class for Cleidopus (genus).
/// NCBI TaxId: 88674
/// </summary>
public abstract class Cleidopus : Monocentridae, ICleidopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cleidopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88674;

    /// <inheritdoc />
    public virtual string GenusName => "Cleidopus";

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
