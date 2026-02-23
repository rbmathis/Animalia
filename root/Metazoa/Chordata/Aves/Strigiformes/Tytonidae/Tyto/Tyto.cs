using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Tytonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Tytonidae.Tyto;

/// <summary>
/// Abstract class for Tyto (genus).
/// NCBI TaxId: 56312
/// </summary>
public abstract class Tyto : Tytonidae, ITyto
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tyto";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56312;

    /// <inheritdoc />
    public virtual string GenusName => "Tyto";

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
