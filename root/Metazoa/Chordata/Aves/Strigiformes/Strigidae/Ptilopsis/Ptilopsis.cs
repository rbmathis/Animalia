using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Ptilopsis;

/// <summary>
/// Abstract class for Ptilopsis (genus).
/// NCBI TaxId: 507971
/// </summary>
public abstract class Ptilopsis : Strigidae, IPtilopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptilopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 507971;

    /// <inheritdoc />
    public virtual string GenusName => "Ptilopsis";

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
