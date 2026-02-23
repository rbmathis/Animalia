using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Thaumatichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Thaumatichthyidae.Lasiognathus;

/// <summary>
/// Abstract class for Lasiognathus (genus).
/// NCBI TaxId: 412643
/// </summary>
public abstract class Lasiognathus : Thaumatichthyidae, ILasiognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lasiognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412643;

    /// <inheritdoc />
    public virtual string GenusName => "Lasiognathus";

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
