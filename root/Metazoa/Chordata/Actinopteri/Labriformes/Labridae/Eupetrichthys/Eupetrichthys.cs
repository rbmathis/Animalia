using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Eupetrichthys;

/// <summary>
/// Abstract class for Eupetrichthys (genus).
/// NCBI TaxId: 242811
/// </summary>
public abstract class Eupetrichthys : Labridae, IEupetrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eupetrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242811;

    /// <inheritdoc />
    public virtual string GenusName => "Eupetrichthys";

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
