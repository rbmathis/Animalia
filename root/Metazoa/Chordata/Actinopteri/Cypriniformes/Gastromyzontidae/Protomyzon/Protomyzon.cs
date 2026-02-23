using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Protomyzon;

/// <summary>
/// Abstract class for Protomyzon (genus).
/// NCBI TaxId: 241452
/// </summary>
public abstract class Protomyzon : Gastromyzontidae, IProtomyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protomyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241452;

    /// <inheritdoc />
    public virtual string GenusName => "Protomyzon";

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
