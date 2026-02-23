using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Scarus;

/// <summary>
/// Abstract class for Scarus (genus).
/// NCBI TaxId: 59660
/// </summary>
public abstract class Scarus : Labridae, IScarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59660;

    /// <inheritdoc />
    public virtual string GenusName => "Scarus";

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
