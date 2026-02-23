using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Anchichoerops;

/// <summary>
/// Abstract class for Anchichoerops (genus).
/// NCBI TaxId: 990926
/// </summary>
public abstract class Anchichoerops : Labridae, IAnchichoerops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anchichoerops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990926;

    /// <inheritdoc />
    public virtual string GenusName => "Anchichoerops";

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
