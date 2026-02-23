using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Malapterus;

/// <summary>
/// Abstract class for Malapterus (genus).
/// NCBI TaxId: 241320
/// </summary>
public abstract class Malapterus : Labridae, IMalapterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malapterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241320;

    /// <inheritdoc />
    public virtual string GenusName => "Malapterus";

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
