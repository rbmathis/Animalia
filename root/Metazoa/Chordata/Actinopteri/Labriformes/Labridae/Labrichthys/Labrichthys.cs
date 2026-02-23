using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Labrichthys;

/// <summary>
/// Abstract class for Labrichthys (genus).
/// NCBI TaxId: 241305
/// </summary>
public abstract class Labrichthys : Labridae, ILabrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241305;

    /// <inheritdoc />
    public virtual string GenusName => "Labrichthys";

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
