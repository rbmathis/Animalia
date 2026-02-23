using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Lachnolaimus;

/// <summary>
/// Abstract class for Lachnolaimus (genus).
/// NCBI TaxId: 202589
/// </summary>
public abstract class Lachnolaimus : Labridae, ILachnolaimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lachnolaimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202589;

    /// <inheritdoc />
    public virtual string GenusName => "Lachnolaimus";

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
