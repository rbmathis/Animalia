using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Thaumatichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Thaumatichthyidae.Thaumatichthys;

/// <summary>
/// Abstract class for Thaumatichthys (genus).
/// NCBI TaxId: 412641
/// </summary>
public abstract class Thaumatichthys : Thaumatichthyidae, IThaumatichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thaumatichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412641;

    /// <inheritdoc />
    public virtual string GenusName => "Thaumatichthys";

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
